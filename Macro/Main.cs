using System;
using System.Windows.Forms;
using Silence.Macro;

namespace Macro
{
    public partial class Main : Form
    {
        private readonly MacroRecorder _recorder = new MacroRecorder();
        private readonly MacroPlayer _player = new MacroPlayer();
        private Timer MacroTimer = new Timer();
        private RecordTimer StopWatch = new RecordTimer();

        public Main()
        {
            InitializeComponent();
            MacroTimer.Tick += MacroTimer_Tick;
        }
        private void MacroTimer_Tick(object sender, EventArgs e)
        {
            TimerLabel.Text = StopWatch.GetString();
        }
        private void RecordBtn_Click(object sender, EventArgs e)
        {
            if (_recorder.CurrentMacro != null && _recorder.CurrentMacro.Events.Length > 0)
            {
                var result = MessageBox.Show(this, 
                "This will continue appending to your current macro," + 
                "would you like to start over and clear the current macro?",
                "Clear Macro?", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    _recorder.Clear();
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }
            MacroLogLV.Items.Clear();
            StopWatch.Restart();
            StopWatch.Start();
            MacroTimer.Start();
            _recorder.StartRecording();
            _recorder.CurrentMacro.OnKeyTrigger += CurrentMacro_OnKeyTrigger;
            _recorder.CurrentMacro.OnMouseTrigger += CurrentMacro_OnMouseTrigger;
            StatusLabel.Text = "Status: Recording...";
        }
        private void CurrentMacro_OnMouseTrigger(MacroEvent Event)
        {
            string eventValue = Event.ToXml().Replace("<MacroMouseUpEvent>", "").
                Replace("</MacroMouseUpEvent>", "").
                Replace("<Location>", "Location: ").
                Replace("</Location>", "").
                Replace("<Button>", ", Button: ").
                Replace("</Button>", "");
            var item = new ListViewItem(Event.ToString());
            item.SubItems.Add(eventValue);
            MacroLogLV.Items.Add(item);
        }
        private void CurrentMacro_OnKeyTrigger(MacroEvent Event)
        {
            string eventValue = Event.ToXml().Replace("<MacroKeyUpEvent>", "").
                Replace("</MacroKeyUpEvent>", "").
                Replace("<VirtualKeyCode>", "").
                Replace("</VirtualKeyCode>", "");

            var item = new ListViewItem(Event.ToString());
            item.SubItems.Add("Key Pressed: " + VirtualKeyCode.GetKeyData(Convert.ToInt32(eventValue)));
            MacroLogLV.Items.Add(item);
        }
        private void StopBtn_Click(object sender, EventArgs e)
        {
            if (_recorder.IsRunning)
            {
                _recorder.StopRecording();
                StopWatch.Stop();
                MacroTimer.Stop();
            }
            else if (_player.IsPlaying)
            {
                _player.CancelPlayback();
            }
            StatusLabel.Text = "Status: Recording stopped";
        }
        private void PlayBtn_Click(object sender, EventArgs e)
        {
            _player.Repetitions = (int)RepetitionsN.Value;
            _player.LoadMacro(_recorder.CurrentMacro);
            _player.PlayMacroAsync();
            StatusLabel.Text = "Status: Playing recording (Repeat: " + _player.Repetitions + " times)";
        }
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            if (_recorder.CurrentMacro != null && _recorder.CurrentMacro.Events.Length > 0)
            {
                var result = MessageBox.Show(this, "Are you sure you want to clear the current macro?",
                    "Clear Macro?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    _recorder.Clear();
                    StatusLabel.Text = "Status: Macro cleared";
                    MacroLogLV.Items.Clear();
                }
            }
        }
        private void LoadBtn_Click(object sender, EventArgs e)
        {
            if (_recorder.CurrentMacro != null && _recorder.CurrentMacro.Events.Length > 0)
            {
                var result = MessageBox.Show(this, "Are you sure you want to load this file and overwrite the currently recorded macro?",
                    "Clear Macro?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                {
                    return;
                }
            }

            var dialog = new OpenFileDialog
            {
                Title = "Open Macro",
                Filter = "Jacobs Macro Files (*.hush)|*.hush|All Files (*.*)|*.*"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var loadedMacro = new Silence.Macro.Macro();
                loadedMacro.Load(dialog.FileName);
                _recorder.LoadMacro(loadedMacro);
                StatusLabel.Text = "Status: Macro loaded";
            }
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (_recorder.CurrentMacro == null || _recorder.CurrentMacro.Events.Length == 0)
            {
                MessageBox.Show(this, "There is no macro currently recorded.",
                    "Cannot Save Macro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var dialog = new SaveFileDialog
            {
                Title = "Save Macro",
                Filter = "Jacobs Macro Files (*.hush)|*.hush|All Files (*.*)|*.*"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _recorder.CurrentMacro.Save(dialog.FileName);
                StatusLabel.Text = "Status: Macro saved";
            }
        }
    }
}

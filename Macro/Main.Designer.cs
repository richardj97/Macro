namespace Macro
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.RepetitionsN = new System.Windows.Forms.NumericUpDown();
            this.NavigationPanel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.SaveBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.label7 = new System.Windows.Forms.Label();
            this.LoadBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.label6 = new System.Windows.Forms.Label();
            this.ClearBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PlayBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.label3 = new System.Windows.Forms.Label();
            this.StopBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.RecordBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.TimerLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.MacroLogLV = new System.Windows.Forms.ListView();
            this.Event = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.RepetitionsN)).BeginInit();
            this.NavigationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaveBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClearBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecordBtn)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(499, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Repeat:";
            // 
            // RepetitionsN
            // 
            this.RepetitionsN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RepetitionsN.Location = new System.Drawing.Point(550, 13);
            this.RepetitionsN.Name = "RepetitionsN";
            this.RepetitionsN.Size = new System.Drawing.Size(56, 20);
            this.RepetitionsN.TabIndex = 4;
            this.RepetitionsN.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NavigationPanel
            // 
            this.NavigationPanel.BackColor = System.Drawing.SystemColors.Control;
            this.NavigationPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NavigationPanel.Controls.Add(this.label8);
            this.NavigationPanel.Controls.Add(this.SaveBtn);
            this.NavigationPanel.Controls.Add(this.label7);
            this.NavigationPanel.Controls.Add(this.LoadBtn);
            this.NavigationPanel.Controls.Add(this.label6);
            this.NavigationPanel.Controls.Add(this.ClearBtn);
            this.NavigationPanel.Controls.Add(this.numericUpDown1);
            this.NavigationPanel.Controls.Add(this.label5);
            this.NavigationPanel.Controls.Add(this.label4);
            this.NavigationPanel.Controls.Add(this.RepetitionsN);
            this.NavigationPanel.Controls.Add(this.PlayBtn);
            this.NavigationPanel.Controls.Add(this.label1);
            this.NavigationPanel.Controls.Add(this.label3);
            this.NavigationPanel.Controls.Add(this.StopBtn);
            this.NavigationPanel.Controls.Add(this.label2);
            this.NavigationPanel.Controls.Add(this.RecordBtn);
            this.NavigationPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavigationPanel.Location = new System.Drawing.Point(0, 0);
            this.NavigationPanel.Name = "NavigationPanel";
            this.NavigationPanel.Size = new System.Drawing.Size(617, 69);
            this.NavigationPanel.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(301, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Save";
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.SystemColors.Control;
            this.SaveBtn.Image = global::Macro.Properties.Resources.icons8_save_50;
            this.SaveBtn.ImageActive = null;
            this.SaveBtn.Location = new System.Drawing.Point(301, 13);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(30, 30);
            this.SaveBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SaveBtn.TabIndex = 19;
            this.SaveBtn.TabStop = false;
            this.SaveBtn.Zoom = 10;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(241, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Load";
            // 
            // LoadBtn
            // 
            this.LoadBtn.BackColor = System.Drawing.SystemColors.Control;
            this.LoadBtn.Image = global::Macro.Properties.Resources.icons8_open_48;
            this.LoadBtn.ImageActive = null;
            this.LoadBtn.Location = new System.Drawing.Point(241, 13);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(30, 30);
            this.LoadBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LoadBtn.TabIndex = 17;
            this.LoadBtn.TabStop = false;
            this.LoadBtn.Zoom = 10;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(182, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Clear";
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.SystemColors.Control;
            this.ClearBtn.Image = global::Macro.Properties.Resources.icons8_cancel_481;
            this.ClearBtn.ImageActive = null;
            this.ClearBtn.Location = new System.Drawing.Point(182, 13);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(30, 30);
            this.ClearBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ClearBtn.TabIndex = 15;
            this.ClearBtn.TabStop = false;
            this.ClearBtn.Zoom = 10;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown1.Location = new System.Drawing.Point(550, 40);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(56, 20);
            this.numericUpDown1.TabIndex = 14;
            this.numericUpDown1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(499, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Speed:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Play";
            // 
            // PlayBtn
            // 
            this.PlayBtn.BackColor = System.Drawing.SystemColors.Control;
            this.PlayBtn.Image = global::Macro.Properties.Resources.icons8_play2_48;
            this.PlayBtn.ImageActive = null;
            this.PlayBtn.Location = new System.Drawing.Point(122, 8);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(38, 38);
            this.PlayBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PlayBtn.TabIndex = 11;
            this.PlayBtn.TabStop = false;
            this.PlayBtn.Zoom = 10;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Stop";
            // 
            // StopBtn
            // 
            this.StopBtn.BackColor = System.Drawing.SystemColors.Control;
            this.StopBtn.Image = global::Macro.Properties.Resources.icons8_stop_48;
            this.StopBtn.ImageActive = null;
            this.StopBtn.Location = new System.Drawing.Point(65, 8);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(38, 38);
            this.StopBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.StopBtn.TabIndex = 9;
            this.StopBtn.TabStop = false;
            this.StopBtn.Zoom = 10;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Record";
            // 
            // RecordBtn
            // 
            this.RecordBtn.BackColor = System.Drawing.SystemColors.Control;
            this.RecordBtn.Image = global::Macro.Properties.Resources.icons8_record_48;
            this.RecordBtn.ImageActive = null;
            this.RecordBtn.Location = new System.Drawing.Point(8, 8);
            this.RecordBtn.Name = "RecordBtn";
            this.RecordBtn.Size = new System.Drawing.Size(38, 38);
            this.RecordBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RecordBtn.TabIndex = 5;
            this.RecordBtn.TabStop = false;
            this.RecordBtn.Zoom = 10;
            this.RecordBtn.Click += new System.EventHandler(this.RecordBtn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel,
            this.TimerLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 479);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(617, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(553, 17);
            this.StatusLabel.Spring = true;
            this.StatusLabel.Text = "Status: Not running";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TimerLabel
            // 
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(49, 17);
            this.TimerLabel.Text = "00:00:00";
            // 
            // MacroLogLV
            // 
            this.MacroLogLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Event,
            this.Value});
            this.MacroLogLV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MacroLogLV.FullRowSelect = true;
            this.MacroLogLV.GridLines = true;
            this.MacroLogLV.Location = new System.Drawing.Point(0, 69);
            this.MacroLogLV.MultiSelect = false;
            this.MacroLogLV.Name = "MacroLogLV";
            this.MacroLogLV.Size = new System.Drawing.Size(617, 410);
            this.MacroLogLV.TabIndex = 8;
            this.MacroLogLV.UseCompatibleStateImageBehavior = false;
            this.MacroLogLV.View = System.Windows.Forms.View.Details;
            // 
            // Event
            // 
            this.Event.Tag = "";
            this.Event.Text = "Event";
            this.Event.Width = 305;
            // 
            // Value
            // 
            this.Value.Tag = "";
            this.Value.Text = "Value";
            this.Value.Width = 307;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(617, 501);
            this.Controls.Add(this.MacroLogLV);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.NavigationPanel);
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mouse Recorder";
            ((System.ComponentModel.ISupportInitialize)(this.RepetitionsN)).EndInit();
            this.NavigationPanel.ResumeLayout(false);
            this.NavigationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaveBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClearBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecordBtn)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown RepetitionsN;
        private Bunifu.Framework.UI.BunifuImageButton RecordBtn;
        private System.Windows.Forms.Panel NavigationPanel;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuImageButton StopBtn;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuImageButton PlayBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel TimerLabel;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuImageButton ClearBtn;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuImageButton LoadBtn;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuImageButton SaveBtn;
        private System.Windows.Forms.ListView MacroLogLV;
        private System.Windows.Forms.ColumnHeader Event;
        private System.Windows.Forms.ColumnHeader Value;
    }
}


using System.Diagnostics;

namespace Macro
{
    public class RecordTimer
    {
        private Stopwatch SW;

        public RecordTimer()
        {
            SW = new Stopwatch();
        }
        public void Start()
        {
            SW.Start();
        }
        public void Stop()
        {
            SW.Stop();
        }
        public void Restart()
        {
            SW.Reset();
        }
        public string GetString()
        {
            return SW.Elapsed.ToString("hh\\:mm\\:ss");
        }
    }
}

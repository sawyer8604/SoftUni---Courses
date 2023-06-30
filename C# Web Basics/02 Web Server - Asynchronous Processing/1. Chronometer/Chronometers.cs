using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chronometer
{
    public class Chronometers : IChronometer
    {
        public Chronometers()
        {
            Laps = new List<string>();
            
        }        

        public List<string> Laps { get; set; }

        public Stopwatch stopWatch = new Stopwatch();

        public string Lap()
        {
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}.{2:0000}", ts.Minutes, ts.Seconds,
            ts.Milliseconds);
            Laps.Add(elapsedTime);
           
            return elapsedTime;
        }

        public void Reset()
        {
            stopWatch.Reset();
        }

        public void Start()
        {
            stopWatch.Start();
        }

        public void Stop()
        {
            stopWatch.Stop();            
        }
    }
}

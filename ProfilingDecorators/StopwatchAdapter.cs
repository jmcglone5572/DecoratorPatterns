using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatterns.ProfilingDecorators
{
    public class StopwatchAdapter : IStopwatch
    {
        private readonly Stopwatch stopwatch;

        public StopwatchAdapter()
        {
            stopwatch = new Stopwatch();
        }

        public void Start()
        {
            stopwatch.Restart();
        }

        public long Stop()
        {
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }
    }
}

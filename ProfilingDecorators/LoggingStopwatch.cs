using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatterns.ProfilingDecorators
{
    public class LoggingStopwatch : IStopwatch
    {
        private readonly IStopwatch decoratedStopwatch;

        public LoggingStopwatch(IStopwatch decoratedStopwatch)
        {
            this.decoratedStopwatch = decoratedStopwatch;
        }

        public void Start()
        {
            decoratedStopwatch.Start();
            Console.WriteLine("Stopwatch started...");
        }

        public long Stop()
        {
            var elapsedMilliseconds = decoratedStopwatch.Stop();

            Console.WriteLine("Stopwatch stopped after {0} seconds", TimeSpan.FromMilliseconds(elapsedMilliseconds).TotalSeconds);

            return elapsedMilliseconds;
        }
    }
}

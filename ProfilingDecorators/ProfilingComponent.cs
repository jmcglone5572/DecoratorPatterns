using DecoratorPatterns.BasicDecorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatterns.ProfilingDecorators
{
    public class ProfilingComponent : IComponent
    {
        private readonly IComponent decoratedComponent;
        private readonly IStopwatch stopwatch;

        public ProfilingComponent(IComponent decoratedComponent, IStopwatch stopwatch)
        {
            this.decoratedComponent = decoratedComponent;
            this.stopwatch = stopwatch;
        }

        public void Something()
        {
            stopwatch.Start();
            decoratedComponent.Something();
            var elapsedMilliseconds = stopwatch.Stop();
            Console.WriteLine("The method took {0} seconds to complete.", elapsedMilliseconds / 1000.0);
        }
    }
}

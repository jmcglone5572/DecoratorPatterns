using System;
using DecoratorPatterns.BasicDecorator;
using System.Threading;

namespace DecoratorPatterns.ProfilingDecorators
{
    public class SlowComponent : IComponent
    {
        private readonly Random random;

        public SlowComponent()
        {
            random = new Random((int)DateTime.Now.Ticks);
        }

        public void Something()
        {
            for(var i = 0; i < 100; i++)
            {
                Thread.Sleep(random.Next(i) * 10);
            }
        }
    }
}

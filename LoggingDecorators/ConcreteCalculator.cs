using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatterns.LoggingDecorators
{
    public class ConcreteCalculator : ICalculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatterns.LoggingDecorators
{
    public interface ICalculator
    {
        int Add(int x, int y);
    }
}

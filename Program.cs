using DecoratorPatterns.BasicDecorator;
using DecoratorPatterns.CompositePattern;
using DecoratorPatterns.LoggingDecorators;
using DecoratorPatterns.ProfilingDecorators;
using System;

namespace DecoratorPatterns
{
    class Program
    {
        static IComponent component;

        static void Main(string[] args)
        {
            component = new DecoratorComponent(new ConcreteComponent());
            component.Something();


            var composite = new CompositeComponent();
            composite.AddComponent(new Leaf());
            composite.AddComponent(new SecondTypeOfLeaf());
            composite.AddComponent(new AThirdLeafType());
            composite.AddComponent(new Leaf());

            component = composite;
            component.Something();

            var calculator = new LoggingCalculator(new ConcreteCalculator());
            calculator.Add(129 , 234);

            var profilingComponent = new ProfilingComponent(new SlowComponent(), new LoggingStopwatch(new StopwatchAdapter()));
            profilingComponent.Something();

            Console.ReadLine();
        }
    }
}

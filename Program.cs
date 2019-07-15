using DecoratorPatterns.BasicDecorator;
using DecoratorPatterns.CompositePattern;

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
        }
    }
}

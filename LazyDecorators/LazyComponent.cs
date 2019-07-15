using System;
using DecoratorPatterns.BasicDecorator;

namespace DecoratorPatterns.LazyDecorators
{
    public class LazyComponent : IComponent
    {
        private readonly Lazy<IComponent> lazyComponent;

        public LazyComponent(Lazy<IComponent> lazyComponent)
        {
            this.lazyComponent = lazyComponent;
        }

        public void Something()
        {
            lazyComponent.Value.Something();
        }
    }
}

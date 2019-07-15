using System;
using DecoratorPatterns.BasicDecorator;
using System.Threading.Tasks;

namespace DecoratorPatterns.AsynchronousDecorators
{
    public class AsyncComponent : IComponent
    {

        private readonly IComponent decoratedComponent;

        public AsyncComponent(IComponent decoratedComponent)
        {
            this.decoratedComponent = decoratedComponent;
        }

        public void Something()
        {
            Task.Run((Action)decoratedComponent.Something);
        }
    }
}

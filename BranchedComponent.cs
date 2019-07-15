using DecoratorPatterns.BasicDecorator;

namespace DecoratorPatterns
{
    public class BranchedComponent : IComponent
    {
        private IComponent trueComponent;
        private IComponent falseComponent;

        private IPredicate predicate;

        public BranchedComponent(IComponent trueComponent, IComponent falseComponent, IPredicate predicate)
        {
            this.trueComponent = trueComponent;
            this.falseComponent = falseComponent;
            this.predicate = predicate;

        }

        public void Something()
        {
            if(predicate.Test())
            {
                trueComponent.Something();
            }
            else
            {
                falseComponent.Something();
            }

        }
    }
}

using DecoratorPatterns.BasicDecorator;
using System.Collections.Generic;

namespace DecoratorPatterns.CompositePattern
{
    public class CompositeComponent :IComponent
    {
        private ICollection<IComponent> children;

        public CompositeComponent()
        {
            children = new List<IComponent>();
        }

        public void AddComponent(IComponent component)
        {
            children.Add(component);
        }

        public void RemoveComponent(IComponent component)
        {
            if (children.Contains(component))
            {
                children.Remove(component);
            }
        }

        public void Something()
        {
            foreach(var child in children)
            {
                child.Something();
            }
        }

    }
}

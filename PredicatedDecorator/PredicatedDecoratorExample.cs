using DecoratorPatterns.BasicDecorator;

namespace DecoratorPatterns.PredicatedDecorator
{

    /// <summary>
    /// Hides conditional execution of code from clients;
    /// </summary>
    public class PredicatedDecoratorExample:IComponent
    {
        private IComponent decoratedComponent;
        private DateTester dateTester;

        public PredicatedDecoratorExample(IComponent decoratedComponent, DateTester dateTester)
        {
            this.decoratedComponent = decoratedComponent;
            this.dateTester = dateTester;
        }

        public void Something()
        {
            if(dateTester.IsTodayAnEvenDayOfTheMonth)
            {
                decoratedComponent.Something();
            }
        }
    }
}

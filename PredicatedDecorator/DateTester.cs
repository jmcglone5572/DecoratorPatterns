using System;

namespace DecoratorPatterns.PredicatedDecorator
{
    public class DateTester
    {
        public bool IsTodayAnEvenDayOfTheMonth
        {
            get
            {
                return DateTime.Now.Day % 2 == 0;
            }
        }
    }
}

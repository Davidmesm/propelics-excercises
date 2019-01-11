using System;

namespace Excercise7
{
    public class Calendar
    {
        public bool IsLeapYear(int year)
        {
            if (year < 0)
            {
                throw new ArgumentException("Not valid year.");
            }

            if (year % 4 != 0)
            {
                return false;
            }
            else if(year % 100 != 0)
            {
                return true;
            }
            else if(year % 400 != 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

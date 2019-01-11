using System;

namespace Excercise2
{
    public class Clock
    {
        const int totalAngle = 360;
        const int anglePerMinute = 360/60;
        const int anglePerHour = 360/12;

        public int GetAngle(int hour, int minutes)
        {
            int result;
            int hourAngle = hour * anglePerHour;
            int minuteAngle = minutes * anglePerMinute;

            //Validate that the information for hour and minutes is correct
            if(hour > 12 || hour < 1)
            {
                throw new System.ArgumentException("Hour can't be less than 1 and bigger than 12.");
            }
            if(minutes < 0 || minutes > 59)
            {
                throw new System.ArgumentException("Minutes can't be less than 0 and bigger than 59.");
            }

            //validate which comes first
            if(hourAngle <= minuteAngle)
            {
                //get the difference between both angles
                result = minuteAngle - hourAngle;
                //Console.WriteLine("minuteAngle: {0} - hourangule: {1} = result: {2}", minuteAngle, hourAngle, result);
            }
            else
            {   
                //get the difference between both angles
                result = hourAngle - minuteAngle;
                //Console.WriteLine(" - minuteAngle: {0} + hourangule: {1} = result: {2}", minuteAngle, hourAngle, result);
            }

            //To verify it is the inner angle, we need to check it is not bigger than 180 degrees
            if(result > 180)
            {
                result = (result - 360)*(-1);
            }

            return result;
        }
    }
}

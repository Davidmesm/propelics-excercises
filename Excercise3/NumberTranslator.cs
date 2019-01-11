﻿using System;
using System.Text;

namespace Excercise3
{
    public class NumberTranslator
    {
        //Transforms a decimal number to a roman number
        public string FromDecimalToRoman(int number)
        {
            string result = "";
            StringBuilder sb = new StringBuilder();

            //Validates number is in the range 1-3999
            if(number < 1 || number > 3999)
            {
                throw new System.ArgumentException("Number can't be less than 1 and bigger than 3999.");
            }

            //Goes through the number and appends the roman number while is subtracts the number from the decimal.
            do{
                if(number >= 1000)
                {
                    sb.Append("M");
                    number -= 1000;
                }
                else if(number >= 900)
                {
                    sb.Append("CM");
                    number -= 900;
                }
                else if(number >= 500)
                {
                    sb.Append("D");
                    number -= 500;
                }
                else if(number >= 400)
                {
                    sb.Append("CD");
                    number -= 400;
                }
                else if(number >= 100)
                {
                    sb.Append("C");
                    number -= 100;
                }
                else if(number >= 90)
                {
                    sb.Append("XC");
                    number -= 90;
                }
                else if(number >= 50)
                {
                    sb.Append("L");
                    number -= 50;
                }
                else if(number >= 40)
                {
                    sb.Append("XL");
                    number -= 40;
                }
                else if(number >= 10)
                {
                    sb.Append("X");
                    number -= 10;
                }
                else if(number >= 9)
                {
                    sb.Append("IX");
                    number -= 9;
                }
                else if(number >= 5)
                {
                    sb.Append("V");
                    number -= 5;
                }
                else if(number >= 4)
                {
                    sb.Append("IV");
                    number -= 4;
                }
                else if(number >= 1)
                {
                    sb.Append("I");
                    number -= 1;
                }
            }while(number > 0);

            result = sb.ToString();

            return result;
        }

    }
}

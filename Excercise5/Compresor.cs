using System;
using System.Text;

namespace Excercise5
{
    public class Compresor
    {
        //Compress string counting repeated letters
        public string Compress(string value)
        {
            string result = value;
            var sb = new StringBuilder();
            
            int counter = 0;
            for(int i = 0; i < value.Length; i++)
            {
                //First Letter
                if(counter == 0)
                {
                    sb.Append(value[i]);
                    counter++;
                }
                //Last Letter
                else if(i == (value.Length - 1))
                {
                    //Same than last letter
                    if(value[i] == value[i-1])
                    {
                        sb.Append(++counter);
                    }
                    //Different letter
                    else
                    {
                        if(counter > 1)
                        {
                            sb.Append(counter);
                        }
                        sb.Append(value[i]);
                    }
                }
                //Just One Letter
                else if(counter == 1)
                {
                    //Same than last letter
                    if(value[i] == value[i-1])
                    {
                        counter++;
                    }
                    //Different letter
                    else
                    {
                        sb.Append(value[i]);
                    }
                }
                //More Than One Letter
                else
                {
                    //Same than last letter
                    if(value[i] == value[i-1])
                    {
                        counter++;
                    }
                    //Different letter
                    else
                    {
                        sb.Append(counter);
                        sb.Append(value[i]);
                        counter = 1;
                    }
                }
            }

            //If thecompress word isn't bigger than the original it should return the original.
            if(sb.Length < result.Length)
            {
                result = sb.ToString();
            }

            return result;
        }
    }
}

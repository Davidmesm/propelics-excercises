using System;
using System.Text;

namespace Excercise6
{
    public class StringTransformer
    {
        //Reverse String
        public string Reverse(string value)
        {
            var sb = new StringBuilder();

            for(int i = (value.Length - 1); i >= 0; i--)
            {
                sb.Append(value[i]);
            }

            return sb.ToString();
        }
    }
}

using System;

namespace Excercise4
{
    public class Anagram
    {
        //Verify if one word is anagram of the other one
        public bool Verify(string firstWord, string secondWord)
        {
            bool result = false;

            //Remove spaces, change everything to lower case and transform to an array
            var aFirstWord = firstWord.Replace(" ",string.Empty).ToLower().ToCharArray();
            var aSecondWord = secondWord.Replace(" ",string.Empty).ToLower().ToCharArray();

            //Sort arrays
            Array.Sort(aFirstWord);
            Array.Sort(aSecondWord);

            //If there is the same length of charcaters compare each one
            if(aFirstWord.Length == aSecondWord.Length)
            {
                result = true;
                for(int i = 0; i < aFirstWord.Length; i++)
                {
                    if(aFirstWord[i] != aSecondWord[i])
                    {
                        result = false;
                    }
                }
            }
            
            return result;
        }
    }
}

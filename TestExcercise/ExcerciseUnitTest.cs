using System;
using Xunit;
using Excercise1;
using Excercise2;
using Excercise3;
using Excercise4;
using Excercise5;
using Excercise6;
using Excercise7;


namespace ExcerciseUnitTest
{
    public class Excercise1UnitTest
    {
        [Theory]
        [InlineData(1D)]
        [InlineData(2D)]
        [InlineData(3D)]
        [InlineData(4D)]
        [InlineData(5D)]
        [InlineData(6D)]
        public void TestCalculatorResolveSequence(double k)
        {
            //Results for each Inline Data
            double[] results = { 1D, -(1D / 3D), (1D / 5D), -(1D / 7D), (1D / 9D), -(1D / 11D) };

            var calc = new Calculator();

            //Validate that the result of teh secuence is valid for each Inline Data
            Assert.Equal(calc.ResolveSequence(k), results[(int)k - 1]);
        }
    }

    public class Excercise2UnitTest
    {
        //Validates some known values
        [Theory]
        [InlineData(12, 0, 0)]
        [InlineData(3, 0, 90)]
        [InlineData(12, 15, 90)]
        [InlineData(6, 0, 180)]
        [InlineData(3, 30, 90)]
        [InlineData(6, 15, 90)]
        [InlineData(9, 0, 90)]
        public void TestClockGetAngle(int hour, int minute, int result)
        {
            var clock = new Clock();
            Assert.Equal(clock.GetAngle(hour, minute), result);
        }

        //Validates that with incorrect values for hours and minutes it throws an exception
        [Theory]
        [InlineData(0, 0)]
        [InlineData(13, 0)]
        [InlineData(12, -1)]
        [InlineData(12, 60)]
        [InlineData(13, 60)]
        public void TestErrorGetAngle(int hour, int minute)
        {
            var clock = new Clock();
            Assert.Throws<ArgumentException>(() => clock.GetAngle(hour, minute));
        }
    }

    public class Excercise3UnitTest
    {
        //Validates numbers are correctly translated to roman
        [Theory]
        [InlineData(1, "I")]
        [InlineData(4, "IV")]
        [InlineData(5, "V")]
        [InlineData(6, "VI")]
        [InlineData(9, "IX")]
        [InlineData(10, "X")]
        [InlineData(40, "XL")]
        [InlineData(90, "XC")]
        [InlineData(400, "CD")]
        [InlineData(900, "CM")]
        [InlineData(3999, "MMMCMXCIX")]
        public void TestNumberTranslatorFromDecimalToRoman(int numberDecimal, string numberRoman)
        {
            var numberTranslator = new NumberTranslator();

            Assert.Equal(numberTranslator.FromDecimalToRoman(numberDecimal), numberRoman);
        }

        //Validate Exception throws if number is less than 1 and bigger than 3999
        [Theory]
        [InlineData(0)]
        [InlineData(4000)]
        public void TestErrorNumberTranslatorInvalidArgument(int number)
        {
            var numberTranslator = new NumberTranslator();

            Assert.Throws<ArgumentException>(() => numberTranslator.FromDecimalToRoman(number));
        }
    }

    public class Excercise4UnitTest
    {
        //Validates words ar anagrams of the other words
        [Theory]
        [InlineData("conversation", "voices rant on")]
        [InlineData("dormitory", "dirty room")]
        [InlineData("dynamite", "may it end")]
        [InlineData("eleven plus two", "twelve plus one")]
        public void TestAnagramVerifyTrue(string firstWord, string secondWord)
        {
            var anagram = new Anagram();
            Assert.True(anagram.Verify(firstWord, secondWord));
        }

        //Validates words are not anagrams of the other words
        [Theory]
        [InlineData("a", "aa")]
        [InlineData("aa", "ab")]
        [InlineData("aab", "ab")]
        public void TestAnagramVerifyFalse(string firstWord, string secondWord)
        {
            var anagram = new Anagram();
            Assert.False(anagram.Verify(firstWord, secondWord));
        }
    }

    public class Excercise5UnitTest
    {
        //Validate the strings ar compressed correctly
        [Theory]
        [InlineData("aabcccccaaa", "a2bc5a3")]
        [InlineData("aabb", "aabb")]
        [InlineData("aabccccca", "a2bc5a")]
        public void TestCompresorCompress(string word, string compressResult)
        {
            var compressor = new Compresor();
            Assert.Equal(compressResult, compressor.Compress(word));
        }
    }

    public class Exercise6UnitTest
    {
        //Validate it reverse correctly the string
        [Theory]
        [InlineData("123456789", "987654321")]
        public void TestStringTransformerReverse(string value, string result)
        {
            var stringTransformer = new StringTransformer();
            Assert.Equal(result, stringTransformer.Reverse(value));
        }
    }

    public class Exercise7UnitTest
    {
        //Validate it is a leap year
        [Theory]
        [InlineData(1804)]
        [InlineData(1904)]
        [InlineData(2016)]
        [InlineData(2020)]
        [InlineData(2400)]
        [InlineData(1860)]
        public void TestCalendarIsLeapYearTrue(int year)
        {
            var calendar = new Calendar();
            Assert.True(calendar.IsLeapYear(year));
        }

        //Validate years which are not leap years
        [Theory]
        [InlineData(1805)]
        [InlineData(2019)]
        public void TestCalendarIsLeapYearFalse(int year)
        {
            var calendar = new Calendar();
            Assert.False(calendar.IsLeapYear(year));
        }
    }
}

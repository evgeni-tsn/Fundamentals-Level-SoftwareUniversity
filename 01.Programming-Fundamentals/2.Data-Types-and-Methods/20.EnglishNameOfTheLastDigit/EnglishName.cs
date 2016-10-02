using System;
using System.Collections.Generic;
using System.Linq;

namespace _20.EnglishNameOfTheLastDigit
{
    /* 
    * Write a method that returns the English name of the last digit of a given number.
    * You can check this code here:
    * https://judge.softuni.bg/Contests/Practice/Index/206#19
    */
    class EnglishName
    {
        static void Main()
        {
            string input = Console.ReadLine();
            GetLastDigitInEnglish(input);
        }

        private static void GetLastDigitInEnglish(string input)
        {
            var lastDigit = input.Last();
            Dictionary<string, string> digits = new Dictionary<string, string>();
            digits.Add("0", "zero");
            digits.Add("1", "one");
            digits.Add("2", "two");
            digits.Add("3", "three");
            digits.Add("4", "four");
            digits.Add("5", "five");
            digits.Add("6", "six");
            digits.Add("7", "seven");
            digits.Add("8", "eight");
            digits.Add("9", "nine");

            Console.WriteLine(digits[lastDigit.ToString()]);
        }
    }
}

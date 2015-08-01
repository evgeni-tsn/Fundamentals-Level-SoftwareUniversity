using System;
using System.Linq;

class ReverseNum
{
    //Write a method that reverses the digits of a given floating-point number.
    static void Main()
    {
        double reversed = GetReversedNumber(double.Parse(Console.ReadLine()));
        Console.WriteLine(reversed);
    }

    static double GetReversedNumber(double number)
    {
        string reversedStr = new string(number.ToString().Reverse().ToArray());
        double reversedDouble = Convert.ToDouble(reversedStr);
        return reversedDouble;
    }
}

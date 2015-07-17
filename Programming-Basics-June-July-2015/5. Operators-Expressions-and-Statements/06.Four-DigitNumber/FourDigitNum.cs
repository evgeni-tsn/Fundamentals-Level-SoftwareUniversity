using System;
class FourDigitNum
{
    //    Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
    //•	Calculates the sum of the digits (in our example 2+0+1+1 = 4).
    //•	Prints on the console the number in reversed order: dcba (in our example 1102).
    //•	Puts the last digit in the first position: dabc (in our example 1201).
    //•	Exchanges the second and the third digits: acbd (in our example 2101).
    //The number has always exactly 4 digits and cannot start with 0.

    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int getA = (number / 1000) % 10;
        int getB = (number / 100) % 10;
        int getC = (number / 10) % 10;
        int getD = (number / 1) % 10;

        Console.WriteLine("Sum of numbers: {0}",getA+getB+getC+getD);
        Console.WriteLine("Reversed order: {0}{1}{2}{3}",getD,getC,getB,getA);
        Console.WriteLine("Last digit on first position: {0}{1}{2}{3}", getD, getA, getB, getC);
        Console.WriteLine("Exchange the second and the third digits: {0}{1}{2}{3}", getA, getC, getB, getD);
    }
}

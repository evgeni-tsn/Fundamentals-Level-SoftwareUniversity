using System;
class PrintSqrt
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        double number = int.Parse(Console.ReadLine());
        Console.WriteLine("Square root of "+number+" is: "+Math.Sqrt(number));
    }
}

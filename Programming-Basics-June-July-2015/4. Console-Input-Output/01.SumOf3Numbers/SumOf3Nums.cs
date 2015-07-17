using System;
class SumOf3Nums
{
    //Write a program that reads 3 real numbers from the console and prints their sum.
    static void Main()
    {
        Console.Write("Enter first num:");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter second num:");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter third num:");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("The sum is: "+(a+b+c));
    }
}
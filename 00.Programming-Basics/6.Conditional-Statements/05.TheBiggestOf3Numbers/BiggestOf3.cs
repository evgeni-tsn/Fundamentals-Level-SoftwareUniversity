using System;
class BiggestOf3
{
    //Write a program that finds the biggest of three numbers. 
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double max = Math.Max(a, Math.Max(b, c));
        Console.WriteLine(max);
    }
}

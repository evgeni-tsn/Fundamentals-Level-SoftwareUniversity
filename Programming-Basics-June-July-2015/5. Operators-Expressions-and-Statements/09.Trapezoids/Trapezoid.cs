using System;
class Trapezoid
{
    //Write an expression that calculates trapezoid's area by given sides a and b and height h.
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());

        double area = ((a + b)*h)/2;
        Console.WriteLine(area);
    }
}

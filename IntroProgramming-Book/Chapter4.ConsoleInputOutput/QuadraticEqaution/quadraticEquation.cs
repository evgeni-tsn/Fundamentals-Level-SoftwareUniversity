using System;
class QuadraticEquation
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double x1 = 0;
        double x2 = 0;
        double x;

        double sqrtPart = b * b - 4 * a * c;

        if (sqrtPart > 0)
        {
            x1 = (-b + Math.Sqrt(sqrtPart)) / (2 * a);
            x2 = (-b - Math.Sqrt(sqrtPart)) / (2 * a);
            Console.WriteLine("x1= {0}", x1);
            Console.WriteLine("x2= {0}", x2);
        }
        else if (sqrtPart < 0)
        {
            sqrtPart = -sqrtPart;
            x = -b / (2 * a);
            Console.WriteLine("no real roots");
        }
        else
        {
            x = (-b + System.Math.Sqrt(sqrtPart)) / (2 * a);
            Console.WriteLine("x1=x2={0}", x);
        }
    }
}

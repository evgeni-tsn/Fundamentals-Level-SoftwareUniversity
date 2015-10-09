using System;
class BiggestOfFive
{
    //Write a program that finds the biggest of five numbers by using only five if statements.
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());
        double e = double.Parse(Console.ReadLine());

        if (a>b&&a>c&&a>d&&a>e)
        {
            Console.WriteLine(a);
        }
        else if (b>=a&&b>=c&&b>=d&&b>=e)
        {
            Console.WriteLine(b);
        }
        else if (c>=a&&c>=b&&c>=d&&c>=e)
        {
            Console.WriteLine(c);
        }
        else if (d>=a&&d>=b&&d>=c&&d>=e)
        {
            Console.WriteLine(d);
        }
        else if (e>=a&&e>=b&&e>=c&&e>=d)
        {
            Console.WriteLine(e);
        }

    }
}

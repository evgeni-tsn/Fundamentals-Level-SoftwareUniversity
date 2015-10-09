using System;
class Sors3NumsNestedIfs
{
    //Write a program that enters 3 real numbers and prints them sorted in descending order. Use nested if statements. Don’t use arrays and the built-in sorting functionality. 
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        if (a == b && b == c)
        {
            Console.WriteLine(a + " " + b + " " + c);
        }
        else
        {
            if (a >= b && a >= c)
            {
                if (b > c)
                {
                    Console.WriteLine(a + " " + b + " " + c);
                }
                else
                {
                    Console.WriteLine(a + " " + c + " " + b);
                }
            }
            if (b >= a && b >= c)
            {
                if (a > c)
                {
                    Console.WriteLine(b + " " + a + " " + c);
                }
                else
                {
                    Console.WriteLine(b + " " + c + " " + a);
                }
            }
            if (c >= a && c >= b)
            {
                if (a > b)
                {
                    Console.WriteLine(c + " " + a + " " + b);
                }
                else
                {
                    Console.WriteLine(c + " " + b + " " + a);
                }
            }
        }
        
    }
}


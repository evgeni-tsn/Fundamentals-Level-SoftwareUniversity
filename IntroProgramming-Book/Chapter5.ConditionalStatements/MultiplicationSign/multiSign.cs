using System;
class multiSign
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        if (a > 0 && b > 0 && c > 0)
        {
            Console.WriteLine("Sign is: +");
        }
        else if (a < 0 && b < 0 && c > 0)
        {
            Console.WriteLine("Sign is: +");
        }
        else if (a < 0 && b > 0 && c < 0)
        {
            Console.WriteLine("Sign is: +");
        }
        else if (a > 0 && b < 0 && c > 0)
        {
            Console.WriteLine("Sign is: +");
        }
        else if (a == 0 && b == 0 && c == 0)
        {
            Console.WriteLine("No sign");
        }
        else
        {
            Console.WriteLine("Sign is: -");
        }

    }
}

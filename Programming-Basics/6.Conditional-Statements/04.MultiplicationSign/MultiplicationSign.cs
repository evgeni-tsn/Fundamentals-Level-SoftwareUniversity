using System;
class MultiplicationSign
{
    //Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it. Use a sequence of if operators. 
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        if ((a > 0 && b > 0 && c > 0) || (a > 0 && b < 0 && c < 0) || (a < 0 && b > 0 && c < 0) || (a < 0 && b < 0 && c > 0))
        {
            Console.WriteLine("+");
        }
        else if (a == 0.0 || b == 0.0 || c == 0.0)
        {
            Console.WriteLine("0");
        }
        else
        {
            Console.WriteLine("-");
        }
    }
}

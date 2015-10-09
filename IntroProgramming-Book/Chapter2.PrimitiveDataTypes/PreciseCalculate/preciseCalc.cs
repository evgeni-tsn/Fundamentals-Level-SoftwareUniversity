using System;
class preciseCalc
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        const double eps = 0.000001;

        if (a > b)
        {
            if (a - b > eps || a - b == eps)
            {
                Console.WriteLine(false);
            }
            else
            {
                Console.WriteLine(true);
            }
        }
        else
        {
            if (b - a > eps || b - a == eps)
            {
                Console.WriteLine(false);
            }
            else
            {
                Console.WriteLine(true);
            }
        }
    }
}

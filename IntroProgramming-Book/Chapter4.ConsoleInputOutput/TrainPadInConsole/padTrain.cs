
using System;
class FormatingNumbers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());

        if (a < 0 || a > 500)
        {
            Console.WriteLine("Invalid data!");
        }

        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        Console.Write("|{0,-10:X}|", a);
        Console.Write(Convert.ToString(a, 2).PadLeft(10, '0') + "|");
        Console.Write("{0,10:F2}|", b);
        Console.WriteLine("{0,-10:F3}|", c);
    }
}

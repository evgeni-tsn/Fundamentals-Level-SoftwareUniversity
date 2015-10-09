using System;
class trapeziodArea
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());

        int area = ((a + b)*h)/2;
        Console.WriteLine(area);
    }
}

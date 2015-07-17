using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());

        double sum = 1;
        double factorial = 1;

        for (int count = 1; count <= n; count++)
        {
            factorial *= count;
            double divider = Math.Pow(x, count);
            sum += factorial / divider;
        }
        Console.WriteLine("{0:F5}", sum);
    }
}
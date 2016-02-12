using System;
class SumOfNnums
{
    static void Main()
    {
        int nums = int.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 0; i < nums; i++)
        {
            double num = double.Parse(Console.ReadLine());
            sum += num;
        }
        Console.WriteLine(sum);
    }
}
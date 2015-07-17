using System;
class MinMaxSumAndAverageOfNums
{
    //Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers(displayed with 2 digits after the decimal point). The input starts by the number n(alone in a line) followed by n lines, each holding an integer number.The output is like in the examples below.
    private static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        double avg = 0;
        int max = int.MinValue;
        int min = int.MaxValue;

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            sum += num;
            avg = (double) sum/n;
            if (num>max)    max = num;
            if (num<min)    min = num;
        }
        Console.WriteLine("Min: " + min);
        Console.WriteLine("Max: " + max);
        Console.WriteLine("Sum: "+sum);
        Console.WriteLine("Average: {0:F2}", avg);
    }
}

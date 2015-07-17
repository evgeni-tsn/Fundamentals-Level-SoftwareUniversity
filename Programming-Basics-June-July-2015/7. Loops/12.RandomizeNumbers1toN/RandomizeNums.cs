using System;
using System.Linq;

class RandomizeNums
{
    //Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        Random rand = new Random();

        numbers = Enumerable.Range(1, n).OrderBy(r => rand.Next()).ToArray();

        foreach (var num in numbers)
        {
            Console.Write("{0} ",num);
        }
        Console.WriteLine();
    }
}

using System;
class RandomInRange
{
    //Write a program that enters 3 integers n, min and max (min ≤ max) and prints n random numbers in the range [min...max]. 
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int min = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());

        Random rand = new Random();

        for (int i = 0; i < n; i++)
        {
            Console.Write("{0} ",rand.Next(min,max));
        }
    }
}

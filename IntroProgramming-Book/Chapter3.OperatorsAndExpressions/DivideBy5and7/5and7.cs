using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        bool isDivideable = num%7 == 0 && num%5 == 0;
        Console.WriteLine(isDivideable);
    }
}

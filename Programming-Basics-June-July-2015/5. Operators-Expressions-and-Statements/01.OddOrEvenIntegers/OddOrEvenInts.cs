using System;
class OddOrEvenInts
{
    //Write an expression that checks if given integer is odd or even.
    static void Main()
    {
        Console.WriteLine("Is Odd?");
        int num = int.Parse(Console.ReadLine());

        bool isOdd = num%2 == 0;

        Console.WriteLine(!isOdd);
    }
}
using System;
class BitAtGivenPosition
{
    //Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n has value of 1. 
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());

        n = n >> p;
        int bit = n & 1;

        bool check = bit == 1;
        Console.WriteLine(check);
    }
}
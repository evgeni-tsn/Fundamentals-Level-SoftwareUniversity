using System;
class NumsComplicated
{
    //Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0. 
    static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        int p = 0;

        if ((start % 5 == 0) || ((start * end <= 0) && (start % 5 != 0)))
        {
            p++;
        }
        Console.WriteLine(p + Math.Abs(end / 5 - start / 5));
    }
}

using System;
class BiggerNumber
{
    //Write a method GetMax() with two parameters that returns the larger of two integers. 
    //Write a program that reads 2 integers from the console and prints the largest of them 
    //using the method GetMax().
    static void Main()
    {
       int firstNum = int.Parse(Console.ReadLine());
       int secondNum = int.Parse(Console.ReadLine());

       long max = GetMax(firstNum, secondNum);
       Console.WriteLine(max);
    }

    static long GetMax(int firstNum, int secondNum)
    {
        long max = Math.Max(firstNum, secondNum);
        return max;
    }
}

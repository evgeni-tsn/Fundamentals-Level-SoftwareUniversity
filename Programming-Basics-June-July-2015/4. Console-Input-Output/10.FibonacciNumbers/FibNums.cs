using System;
class FibNums
{
    //Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by spaces) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …. Note that you may need to learn how to use loops. 
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int firstNum = 0;
        int secondNum = 1;
        int thirdNum = 0;

        if (n == 1)
        {
            Console.Write(0);
        }
        else if (n == 2)
        {
            Console.Write("0 1");
        }
        else if (n <= 0)
        {
            Console.Write("Invalid data!");
        }
        else
        {
            Console.Write("{0} {1}", firstNum, secondNum);
            for (int i = 2; i < n; i++)
            {
                thirdNum = firstNum + secondNum;
                Console.Write(" {0}", thirdNum);
                firstNum = secondNum;
                secondNum = thirdNum;
            }
        }
        Console.WriteLine();
    }
}
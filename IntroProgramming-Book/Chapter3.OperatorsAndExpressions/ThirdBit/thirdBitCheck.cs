using System;
class thirdBitCheck
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        int mask = 8;

        int result = num & mask;
        if (result==0)
        {
            Console.WriteLine("Third bit is: 0");
        }
        else
        {
            Console.WriteLine("Third bit is: 1");
        }
    }
}
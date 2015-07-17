using System;
class DecToBin
{
    //Using loops write a program that converts an integer number to its binary representation. The input is entered as long. The output should be a variable of type string. Do not use the built-in .NET functionality. 
    static void Main()
    {
        long decNumber = long.Parse(Console.ReadLine());
        string bigNumber = "";
        while (decNumber != 0)
        {
            int remain = (int)decNumber % 2;
            decNumber /= 2;
            bigNumber = remain + bigNumber;
        }
        Console.WriteLine(bigNumber);
    }
}

using System;

namespace _14.IntegerToHexBinary
{
    /* 
    * Create a program to convert a decimal number to hexadecimal and binary number and print it
    * You can check this code here:
    * https://judge.softuni.bg/Contests/Practice/Index/206#13
    */
    class IntToHexBinary
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(input,16).ToUpper());
            Console.WriteLine(Convert.ToString(input,2));
        }
    }
}

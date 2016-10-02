using System;

namespace _04.VariableHexadecimalFormat
{
    /* 
     * Write a program that receives a number in hexadecimal format (0x##) convert it to decimal format and print it. Use Convert.ToInt32().
     * You can check this code here:
     * https://judge.softuni.bg/Contests/Practice/Index/206#3
     */
    class VariableHex
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(Convert.ToInt64(input, 16));
        }
    }
}

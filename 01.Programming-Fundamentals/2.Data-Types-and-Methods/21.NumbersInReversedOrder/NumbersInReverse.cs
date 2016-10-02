using System;
using System.Linq;

namespace _21.NumbersInReversedOrder
{
    /* 
    * Write a method that prints the digits of a given decimal number in a reversed order.
    * You can check this code here:
    * https://judge.softuni.bg/Contests/Practice/Index/206#20
    */
    class NumbersInReverse
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(string.Join("", input.Reverse()));
        }
    }
}

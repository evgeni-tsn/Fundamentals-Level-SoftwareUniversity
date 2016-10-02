using System;
using System.Linq;

namespace _09.ReverseChars
{
    /* 
    * Write a program to ask the user for 3 letters and print them in reversed order.
    * You can check this code here:
    * https://judge.softuni.bg/Contests/Practice/Index/206#8
    */
    class ReverseChars
    {
        static void Main()
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            string third = Console.ReadLine();

            string[] arr = {first, second, third};
            Console.WriteLine(string.Join("", arr.Reverse()));
        }
    }
}

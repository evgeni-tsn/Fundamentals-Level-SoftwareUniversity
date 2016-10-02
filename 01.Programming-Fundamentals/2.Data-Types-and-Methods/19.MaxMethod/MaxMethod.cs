using System;
using System.Linq;

namespace _19.MaxMethod
{
    /* 
    * Create a method GetMax() with two integer (int) parameters, that returns maximal of the two numbers. Write a program that reads three numbers from the console and prints the biggest of them. Use the GetMax() method you just created. 
    * You can check this code here:
    * https://judge.softuni.bg/Contests/Practice/Index/206#18
    */
    class MaxMethod
    {
        static void Main()
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int[] arr = {first, second, third};
            Console.WriteLine(arr.Max());
        }
    }
}

using System;

namespace _03.ExactSumOfRealNumbers
{
    class ExactSumRealNums
    {
        /* You can check this code here:
        * https://judge.softuni.bg/Contests/Practice/Index/171#2
        */
        static void Main()
        {
            decimal n = decimal.Parse(Console.ReadLine());
            decimal sum = 0;
            for (int i = 0; i < n; i++)
            {
                decimal number = decimal.Parse(Console.ReadLine());
                sum += number;
            }

            Console.WriteLine(sum);
        }
    }
}

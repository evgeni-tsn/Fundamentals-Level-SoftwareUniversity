using System;
namespace _22.FibonacciNumbers
{
    /* 
    * Define a method Fib(n) that calculates the nth FibonacciSeq number. Examples:
    * You can check this code here:
    * https://judge.softuni.bg/Contests/Practice/Index/206#21
    */
    class FibonacciSeq
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(Fibonacci(input));
        }

        public static int Fibonacci(int n)
        {
            int a = 1;
            int b = 1;
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
    }
}

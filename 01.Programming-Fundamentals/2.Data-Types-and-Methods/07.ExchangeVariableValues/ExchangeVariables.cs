using System;

namespace _07.ExchangeVariableValues
{
    /* 
     * Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic. Print the variable values before and after the exchange.
     * You can check this code here:
     * https://judge.softuni.bg/Contests/Practice/Index/206#6
     */
    class ExchangeVariables
    {
        static void Main()
        {
            long first = long.Parse(Console.ReadLine());
            long second = long.Parse(Console.ReadLine());

            Console.WriteLine("Before:");
            Console.WriteLine("a = {0}", first);
            Console.WriteLine("b = {0}", second);
            first = first + second;
            second = first - second;
            first = first - second;
            Console.WriteLine("After:");
            Console.WriteLine("a = {0}", first);
            Console.WriteLine("b = {0}", second);
        }
    }
}

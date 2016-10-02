using System;
namespace _05.BooleanVariable
{
    /* 
     * Write a program that receives string, converts it to Boolean variable and prints it on the console. Use Convert.ToBoolean().
     * You can check this code here:
     * https://judge.softuni.bg/Contests/Practice/Index/206#4
     */
    class BooleanVariable
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(Convert.ToBoolean(input));
        }
    }
}

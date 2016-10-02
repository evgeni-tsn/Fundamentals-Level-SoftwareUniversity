using System;

namespace _18.HelloНame_
{
    /* 
    * Write a method that receives a name as parameter and prints on the console. “Hello, <name>!”
    * You can check this code here:
    * https://judge.softuni.bg/Contests/Practice/Index/206#17
    */
    class Hello
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine("Hello, {0}!", input);
        }
    }
}

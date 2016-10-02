using System;

namespace _07.Greeting
{
    class Greeting
    {
        /* You can check this code here:
        * https://judge.softuni.bg/Contests/Practice/Index/171#6
        */
        static void Main()
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string age = Console.ReadLine();

            Console.WriteLine($"Hello, {firstName} {lastName}. You are {age} years old.");
        }
    }
}

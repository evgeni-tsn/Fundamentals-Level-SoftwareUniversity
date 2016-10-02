using System;

namespace _02.ReverseString
{
    /* 
     * Write a program that reads a string from the console, 
     * reverses it and prints the result back at the console.
     * https://judge.softuni.bg/Contests/209/Strings-Dictionaries-Lambda-and-LINQ-Exercises
     */
    class ReverseString
    {
        static void Main()
        {
            var text = Console.ReadLine();
            char[] array = text.ToCharArray();
            Array.Reverse(array);
            Console.WriteLine(new string(array));
        }
    }
}

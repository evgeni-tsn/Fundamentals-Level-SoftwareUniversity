using System;

namespace _01.PrintStringLetters
{
    /*
     * Read a string and print its letters as in the examples below:
     * You can check your solutions here: 
     * https://judge.softuni.bg/Contests/174/Strings-Dictionaries-Lambda-and-LINQ-Lab
     */
    class PrintStringLetters
    {
        static void Main()
        {
            var input = Console.ReadLine().ToCharArray();

            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine("str[{0}] -> '{1}'", i, input[i]);
            }
        }
    }
}

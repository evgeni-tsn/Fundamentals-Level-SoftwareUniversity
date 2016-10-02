using System;
using System.Linq;

namespace _02.MatrixPalindromes
{
    /*
     * Write a program to generate the following matrix of palindromes 
     * of 3 letters with r rows and c columns.
     * You can check your solutions here: 
     * https://judge.softuni.bg/Contests/208/Lists-and-Matrices-Exercises
     */
    class PalindromeMatrix
    {
        static void Main()
        {
            var rawInput = Console.ReadLine().Split().Select(int.Parse).ToList();
            int rows = rawInput[0];
            int cols = rawInput[1];

            string[] alphabet = { "0", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write("{0}{1}{0} ", alphabet[i], alphabet[i + j]);
                }
                Console.WriteLine();
            }
        }
    }
}

using System;
using System.Linq;

namespace _02.RandomizeWords
{
    /* 
     * You are given a list of words in one line.Randomize their order and print each word at a separate line.
     * Print the resulting string on the console.
     * You can check your solutions here: 
     * https://judge.softuni.bg/Contests/175/Objects-and-Classes-Lab
     */
    class RandomizeWords
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().ToList();
            foreach (var word in input)
            {
                Console.WriteLine(word);
            }
        }
    }
}

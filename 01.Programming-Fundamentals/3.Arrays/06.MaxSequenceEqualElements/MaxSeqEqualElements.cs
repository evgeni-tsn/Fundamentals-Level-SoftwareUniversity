using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.MaxSequenceEqualElements
{
    /* 
    * Compare two char arrays lexicographically (letter by letter) and 
    * prints them in correct order each on separate line.
    * You can check this code here:
    * https://judge.softuni.bg/Contests/Practice/Index/207#5
    */
    class MaxSeqEqualElements
    {
        static void Main()
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int maxnumbers = 0;
            int count = 1;
            int maxcount = 1;
            int currentPosition = 0;
            while (currentPosition < input.Count - 1)
            {
                if (input[currentPosition] == input[currentPosition + 1])
                {
                    count++;

                    if (count > maxcount)
                    {
                        maxcount = count;
                        maxnumbers = input[currentPosition];
                    }
                }
                else
                {
                    count = 1;
                }
                currentPosition++;
                if (maxcount == 1)
                {
                    maxnumbers = input[0];
                }
            }

            for (int i = 0; i < maxcount; i++)
            {
                Console.Write(maxnumbers+" ");
            }
        }
    }
}

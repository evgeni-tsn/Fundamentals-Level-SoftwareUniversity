using System;
using System.Linq;

namespace _07.MaxSequenceIncreasingElements
{
    /* 
    * Write a program that finds the maximal increasing sequence in an array.
    * You can check this code here:
    * https://judge.softuni.bg/Contests/Practice/Index/207#6
    */
    class MaxSeqIncreasing
    {
        public static void Main()
        {
            var sequence = Console.ReadLine().Split().Select(long.Parse).ToArray();
            FindLongestIncreasingSubsequence(sequence.ToArray(), sequence.Length);
        }

        static void FindLongestIncreasingSubsequence(long[] numbers, int length)
        {
            int cntCurrSeq = 0;
            int startCurrSeq = 0;
            int cntMaxSeq = 0;
            int startMaxSeq = 0;

            for (int i = 1; i < length; i++)
            {
                if (numbers[i] - numbers[i - 1] >= 1)
                {
                    cntCurrSeq++;
                    startCurrSeq = i - cntCurrSeq;

                    if (cntCurrSeq > cntMaxSeq)
                    {
                        cntMaxSeq = cntCurrSeq;
                        startMaxSeq = startCurrSeq;
                    }
                }
                else
                {
                    cntCurrSeq = 0;
                }
            }
            for (int iWrite = startMaxSeq; iWrite <= (startMaxSeq + cntMaxSeq); iWrite++)
            {
                Console.Write(numbers[iWrite] + " ");
            }
            Console.WriteLine();
        }
    }
}

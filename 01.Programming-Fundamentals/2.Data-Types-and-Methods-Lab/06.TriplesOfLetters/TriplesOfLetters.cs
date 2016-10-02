using System;
using System.Linq;

namespace _06.TriplesOfLetters
{
    class TriplesOfLetters
    {
        /* You can check this code here:
        * https://judge.softuni.bg/Contests/Practice/Index/171#5
        */

        static char[] alpha = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

        static void Main()
        {

            int n = int.Parse(Console.ReadLine());

            int[] array = new int[3];

            GenerateVariations(array, n);
        }

        private static void GenerateVariations(int[] arr, int sizeOfSet, int index = 0)
        {
            if (index >= arr.Length)
            {
                Print(arr);
            }
            else
            {
                for (int i = 1; i <= sizeOfSet; i++)
                {
                    arr[index] = i;
                    GenerateVariations(arr, sizeOfSet, index + 1);
                }
            }
        }

        private static void Print(int[] arr)
        {
            foreach (var i in arr)
            {
                Console.Write(alpha[i-1]);
            }
            Console.WriteLine();
        }
    }
}

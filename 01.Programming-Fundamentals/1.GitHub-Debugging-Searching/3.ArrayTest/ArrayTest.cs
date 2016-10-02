using System;
using System.Linq;

namespace _3.ArrayTest
{
    /* You can check this problem in the judge contest:
    * https://judge.softuni.bg/Contests/Practice/Index/203#2 */
    class ArrayTest
    {
        private const char ArgumentsDelimiter = ' ';
        private static long[] array;

        public static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());

            array = Console.ReadLine()
                .Split(ArgumentsDelimiter)
                .Select(long.Parse)
                .ToArray();

            string command = Console.ReadLine();

            while (command != "stop")
            {
                var line = command.Split(ArgumentsDelimiter);
                int[] args = new int[2];
                if (line[0].Equals("add") ||
                    line[0].Equals("subtract") ||
                    line[0].Equals("multiply"))
                {
                    args[0] = int.Parse(line[1]);
                    args[1] = int.Parse(line[2]);
                }
                PerformAction(array, line[0], args);
                command = Console.ReadLine();
                PrintArray(array);
            }
        }

        static void PerformAction(long[] arr, string action, int[] args)
        {
            int pos = args[0]-1;
            int value = args[1];

            switch (action)
            {
                case "multiply":
                    arr[pos] *= value;
                    break;
                case "add":
                    arr[pos] += value;
                    break;
                case "subtract":
                    arr[pos] -= value;
                    break;
                case "lshift":
                    ArrayShiftLeft(arr);
                    break;
                case "rshift":
                    ArrayShiftRight(arr);
                    break;
            }
        }

        private static void ArrayShiftRight(long[] arr)
        {
            var lastItem = arr.Last();
            for (int i = arr.Length - 1; i >= 1; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[0] = lastItem;
        }

        private static void ArrayShiftLeft(long[] arr)
        {
            var firstItem = arr.First();
            for (int i = 0; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            arr[arr.Length - 1] = firstItem;
        }

        private static void PrintArray(long[] arr)
        {
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}

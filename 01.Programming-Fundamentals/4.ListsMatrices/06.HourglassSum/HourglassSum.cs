using System;
using System.Linq;

namespace _06.HourglassSum
{
    /*
     * You are given a 2D array with dimensions 6x6. An hourglass in an array 
     * is defined as a portion shaped like this:
     * You can check your solutions here: 
     * https://judge.softuni.bg/Contests/208/Lists-and-Matrices-Exercises
     */
    class HourglassSum
    {
        static void Main()
        {
//            long[] rowsAndCols = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long rows = 6;
            long cols = 6;
            long[,] matrix = new long[rows, cols];


            for (long row = 0; row < rows; row++)
            {
                string[] currentRowNumbersAsStrings =
                    Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (long column = 0; column < cols; column++)
                {
                    matrix[row, column] = long.Parse(currentRowNumbersAsStrings[column]);
                }
            }

            long bestSum = long.MinValue;
            long ff = 0, fs = 0, ft = 0, sf = 0, ss = 0, st = 0, tf = 0, ts = 0, tt = 0;
            for (long row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (long col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    long sum = matrix[row, col] +
                              matrix[row, col + 1] +
                              matrix[row, col + 2] +
//                              matrix[row + 1, col] +
                              matrix[row + 1, col + 1] +
//                              matrix[row + 1, col + 2] +
                              matrix[row + 2, col] +
                              matrix[row + 2, col + 1] +
                              matrix[row + 2, col + 2];

                    if (sum > bestSum)
                    {
                        ff = matrix[row + 0, col + 0];
                        fs = matrix[row + 0, col + 1];
                        ft = matrix[row + 0, col + 2];
//                        sf = matrix[row + 1, col + 0];
                        ss = matrix[row + 1, col + 1];
//                        st = matrix[row + 1, col + 2];
                        tf = matrix[row + 2, col + 0];
                        ts = matrix[row + 2, col + 1];
                        tt = matrix[row + 2, col + 2];
                        bestSum = sum;
                    }
                }
            }
            Console.WriteLine(bestSum);
//            Console.WriteLine(ff + " " + fs + " " + ft);
//            Console.WriteLine("-" + " " + ss + " " + "-");
//            Console.WriteLine(tf + " " + ts + " " + tt);
        }
    }
}

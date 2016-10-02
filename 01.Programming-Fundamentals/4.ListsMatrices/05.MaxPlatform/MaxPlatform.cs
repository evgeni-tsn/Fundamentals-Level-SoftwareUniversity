using System;
using System.Linq;

namespace _05.MaxPlatform
{
    /*
     * Write a program, which creates a rectangular array with size of n by m elements.
     * The dimensions and the elements should be read from the console. 
     * Find a platform with size of (3, 3) with a maximal sum. 
     * On the first line of output print the sum and then print the platform itself. 
     * On First line of input you will receive number of rows and columns of the matrix 
     * separated with space.
     * You can check your solutions here: 
     * https://judge.softuni.bg/Contests/208/Lists-and-Matrices-Exercises
     */
    class MaxPlatform
    {
        static void Main()
        {
            long[] rowsAndCols = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long rows = rowsAndCols[0];
            long cols = rowsAndCols[1];
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
                              matrix[row + 1, col] +
                              matrix[row + 1, col + 1] +
                              matrix[row + 1, col + 2] +
                              matrix[row + 2, col] +
                              matrix[row + 2, col + 1] +
                              matrix[row + 2, col + 2];

                    if (sum > bestSum)
                    {
                        ff = matrix[row + 0, col + 0];
                        fs = matrix[row + 0, col + 1];
                        ft = matrix[row + 0, col + 2];
                        sf = matrix[row + 1, col + 0];
                        ss = matrix[row + 1, col + 1];
                        st = matrix[row + 1, col + 2];
                        tf = matrix[row + 2, col + 0];
                        ts = matrix[row + 2, col + 1];
                        tt = matrix[row + 2, col + 2];
                        bestSum = sum;
                    }
                }
            }
            Console.WriteLine(bestSum);
            Console.WriteLine(ff + " " + fs + " " + ft);
            Console.WriteLine(sf + " " + ss + " " + st);
            Console.WriteLine(tf + " " + ts + " " + tt);

        }
    }
}

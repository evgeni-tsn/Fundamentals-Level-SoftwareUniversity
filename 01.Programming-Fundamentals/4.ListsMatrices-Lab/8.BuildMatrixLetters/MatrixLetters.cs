using System;

namespace _8.BuildMatrixLetters
{
    /* 
     * Build a matrix of capital Latin letters of size rows x cols like at the example below.
     * You can check this code here:
     * https://judge.softuni.bg/Contests/Practice/Index/173#7
     */
    class MatrixLetters
    {
        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            var matrix = new char[rows, cols];
            char lettter = 'A';

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = lettter++;
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col <= cols - 1; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

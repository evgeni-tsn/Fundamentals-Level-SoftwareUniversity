using System;
using System.Linq;

namespace _9.RotateMatrix
{
    /* 
    * Write a program to read a matrix of words (space separated) and 
    * rotate it on the right as shown in the examples.
    * You can check this code here:
    * https://judge.softuni.bg/Contests/Practice/Index/173#8
    */
    class RotateMatrix
    {
        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            var matrix = new string[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var line = Console.ReadLine().Split().ToList();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = line[col];
                }
            }

            string[,] output = new string[matrix.GetLength(1), matrix.GetLength(0)];

            for (int row = 0; row < output.GetLength(0); row++)
            {
                for (int col = 0; col < output.GetLength(1); col++)
                {
                    output[row, col] = matrix[matrix.GetLength(0) - 1 - col, row];
                    Console.Write(output[row, col]+ " ");
                }
                Console.WriteLine();
            }
        }
    }
}

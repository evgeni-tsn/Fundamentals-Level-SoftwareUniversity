using System;
using System.Linq;

namespace _04._2x2SquaresMatrix
{
    /*
     * Find the count of 2x2 squares of equal chars in a matrix.
        •	The matrix size (rows and columns) is given at the first row
        •	Matrix characters come at the next rows lines (space separated)
     * You can check your solutions here: 
     * https://judge.softuni.bg/Contests/208/Lists-and-Matrices-Exercises
     */
    class SquaresMatrix
    {
        static void Main()
        {
            var rawInput = Console.ReadLine().Split().Select(int.Parse).ToList();
            int rows = rawInput[0];
            int cols = rawInput[1];
            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] nums = Console.ReadLine().Split();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = Convert.ToChar(nums[col]);
                }
            }

            int bestSum = 0;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1] && 
                        matrix[row, col + 1] == matrix[row + 1, col] && 
                        matrix[row + 1, col] == matrix[row + 1, col + 1])
                    {
                        bestSum++;
                    }
                }
            }
            Console.WriteLine(bestSum);
        }
    }
}

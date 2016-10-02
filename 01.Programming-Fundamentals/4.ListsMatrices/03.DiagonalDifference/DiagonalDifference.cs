using System;
using System.Linq;

namespace _03.DiagonalDifference
{
    /*
     * Write a program that finds absolute difference between the sums of square matrix diagonals. 
     * On the first line you receive N – size of matrix. 
     * On the next N lines, you receive values for every row of the matrix separated with space.
     * You can check your solutions here: 
     * https://judge.softuni.bg/Contests/208/Lists-and-Matrices-Exercises
     */
    class DiagonalDifference
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = nums[col];
                }
            }

            int mainDiagonalSum = 0;
            int secondaryDiagonalSum = 0;

            for (int i = 0; i < n; i++)
            {
                mainDiagonalSum += matrix[i, i];
            }
            for (int i = n - 1; i >= 0; i--)
            {
                secondaryDiagonalSum += matrix[i, n - i - 1];
            }

            Console.WriteLine(Math.Abs(mainDiagonalSum-secondaryDiagonalSum));
        }
    }
}

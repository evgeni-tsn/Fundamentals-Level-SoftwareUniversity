using System;
using System.Linq;

class MatrixOfPalindromes
{
    //Write a program to generate the following matrix of palindromes of 3 letters with r rows and c columns:
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int width = int.Parse(input[0]);
        int height = int.Parse(input[1]);
        string[,] matrix = new string[width, height];
        for (int row = 0; row < width; row++)
        {
            for (int col = 0; col < height; col++)
            {
                matrix[row, col] =
                    "" + (char)('a' + row) + (char)('a' + col + row) + (char)('a' + row);
            }
        }

        for (int row = 0; row < width; row++)
        {
            for (int col = 0; col < height; col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}

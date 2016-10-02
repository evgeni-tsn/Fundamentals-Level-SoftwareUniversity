using System;
using System.Linq;

namespace _07.Matrices
{
    /*
     * Write a program, which creates matrices like those in the figures below
     * and prints them formatted to the console. 
     * The size of the matrices will be read from the console. 
     * You can check your solutions here: 
     * https://judge.softuni.bg/Contests/208/Lists-and-Matrices-Exercises
     */
    class Matrices
    {
        static void Main()
        {
            var input = Console.ReadLine().Split();
            string type = input[0];
            int rows = int.Parse(input[1]);
            int cols = int.Parse(input[2]);

            int[,] matrix = new int[rows, cols];

            switch (type)
            {
                case "A":
                    FillMatrixVertically(matrix);
                    break;
                case "B":
                    FillMatrixSnake(matrix);
                    break;
                case "C":
                    FillMatrixDiagonally(matrix);
                    break;
                case "D":
                    FillMatrixSpiral(matrix);
                    break;
            }
            PrintMatrix(matrix);
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void FillMatrixSpiral(int[,] matrix)
        {
            int row = 0;
            int col = 0;
            string direction = "down";

            for (int i = 1; i <= matrix.GetLength(0) * matrix.GetLength(1); i++)
            {
                if (direction == "right" && (col > matrix.GetLength(1) - 1 || matrix[row, col] != 0))
                {
                    direction = "up";
                    col--;
                    row--;
                }
                if (direction == "down" && (row > matrix.GetLength(0) - 1 || matrix[row, col] != 0))
                {
                    direction = "right";
                    row--;
                    col++;
                }
                if (direction == "left" && (col < 0 || matrix[row, col] != 0))
                {
                    direction = "down";
                    col++;
                    row++;
                }

                if (direction == "up" && row < 0 || matrix[row, col] != 0)
                {
                    direction = "left";
                    row++;
                    col--;
                }

                matrix[row, col] = i;

                if (direction == "right")
                {
                    col++;
                }
                if (direction == "down")
                {
                    row++;
                }
                if (direction == "left")
                {
                    col--;
                }
                if (direction == "up")
                {
                    row--;
                }
            }
        }

        private static void FillMatrixDiagonally(int[,] matrix)
        {
            int counter = 1;

            for (int startingRow = matrix.GetLength(0) - 1; startingRow >= 0; startingRow--)
            {
                int col = 0;
                for (int row = startingRow; row < matrix.GetLength(0); row++)
                {
                    matrix[row, col++] = counter++;
                }
            }

            for (int startingCol = 1; startingCol < matrix.GetLength(1); startingCol++)
            {
                int row = 0;
                for (int col = startingCol; col < matrix.GetLength(1); col++)
                {
                    matrix[row++, col] = counter++;
                }
            }
        }

        private static void FillMatrixVertically(int[,] matrix)
        {
            int currNum = 1;
            for (int row = 0; row < matrix.GetLength(1); row++)
            {
                for (int col = 0; col < matrix.GetLength(0); col++)
                {
                    matrix[col, row] = currNum;
                    currNum++;
                }
            }
        }

        private static void FillMatrixSnake(int[,] matrix)
        {
            int currNum = 1;
            for (int row = 0; row < matrix.GetLength(1); row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < matrix.GetLength(0); col++)
                    {
                        matrix[col, row] = currNum;
                        currNum++;
                    }
                }
                else
                {
                    for (int col = matrix.GetLength(0) - 1; col >= 0; col--)
                    {
                        matrix[col, row] = currNum;
                        currNum++;
                    }
                }
            }
        }
    }
}

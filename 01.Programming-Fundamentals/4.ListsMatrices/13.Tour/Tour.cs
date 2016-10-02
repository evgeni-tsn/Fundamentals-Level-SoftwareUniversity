using System;
using System.Linq;

namespace _13.Tour
{
    /*
     * You are given a square matrix representing distances between cities. 
     * City names are numbers from 0 to N. 
     * Also you are a given a sequence of cities that needs to be visited in that order. 
     * You start from city 0. 
     * Your task is to write a program that reads the distances matrix, 
     * the sequence of numbers representing number of 
     * cities that will be visited starting from city 0 and 
     * finally print the total distance of the route.
     * You can check your solutions here: 
     * https://judge.softuni.bg/Contests/208/Lists-and-Matrices-Exercises
     */
    class Tour
    {
        public static void Main()
        {
            int dimension = int.Parse(Console.ReadLine());
            var graph = InitializeGraph(dimension);

            var distance = GetDistance(graph);

            Console.WriteLine(distance);
        }

        private static int GetDistance(int[,] graph)
        {
            int[] pathInfo =
                Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int distance = 0;
            int currentCity = 0;

            foreach (int city in pathInfo)
            {
                distance += graph[currentCity, city];
                currentCity = city;
            }

            return distance;
        }

        private static int[,] InitializeGraph(int dimension)
        {
            int[,] graph = new int[dimension, dimension];

            for (int row = 0; row < graph.GetLength(0); row++)
            {
                int[] currentRow =
                    Console.ReadLine()
                        .Split()
                        .Select(int.Parse)
                        .ToArray();

                for (int col = 0; col < graph.GetLength(1); col++)
                {
                    graph[row, col] = currentRow[col];
                }
            }

            return graph;
        }
    }
}

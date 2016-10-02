using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.ClosestTwoPoints
{
    /* 
     * Write a program to read n points and print the closest two of them.
     * You can check your solutions here: 
     * https://judge.softuni.bg/Contests/175/Objects-and-Classes-Lab
     */
    class ClosestTwoPoints
    {
        class Point
        {
            public int X { get; set; }
            public int Y { get; set; }
        }
        static void Main()
        {
            // get points
            int numPoints = int.Parse(Console.ReadLine());
            List<Point> points = new List<Point>();
            for (int i = 0; i < numPoints; i++)
            {
                points.Add(ReadPoint());
            }

            // calc distances and keep the min distance and closest points
            List<Point> closestPoints = new List<Point>();
            double minDistance = double.MaxValue;
            for (int i = 0; i < numPoints; i++)
            {
                for (int j = i + 1; j < numPoints; j++)
                {
                    double distance = CalcDistance(points[i], points[j]);
                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        closestPoints.Clear();
                        closestPoints.Add(points[i]);
                        closestPoints.Add(points[j]);
                    }
                }
            }
            // print min distance and closest points
            Console.WriteLine("{0:f3}", minDistance);
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("({0}, {1})", closestPoints[i].X, closestPoints[i].Y);
            }
        }

        static Point ReadPoint()
        {
            int[] coordinates = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            return new Point()
            {
                X = coordinates[0],
                Y = coordinates[1]
            };
        }
        static double CalcDistance(Point point1, Point point2)
        {
            int deltaX = Math.Abs(point2.X - point1.X);
            int deltaY = Math.Abs(point2.Y - point1.Y);
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }
    }
}

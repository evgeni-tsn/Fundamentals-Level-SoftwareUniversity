using System;
using System.Linq;

namespace _3.IntersectionCircles
{
    /* 
     * Create class Circle with properties Center and Radius. 
     * The center is a point with coordinates X and Y (make a class Point). 
     * Write a method bool Intersect(Circle c1, Circle c2) that tells whether the 
     * two given circles intersect or not. 
     * Write a program that tells if two circles intersect.
     * The input lines will be in format: {X} {Y} {Radius}. 
     * Print as output “Yes” or “No”.
     * Print the resulting string on the console.
     * https://judge.softuni.bg/Contests/210/Objects-and-Classes-Exercises
     */

    class CircleIntersection
    {
        static void Main()
        {
            {
                Circle circleA = GetCircle();
                Circle circleB = GetCircle();
                bool circlesIntersect = circleA.Center.DistanceTo(circleB.Center) <=
                                        circleA.Radius + circleB.Radius;
                Console.WriteLine(circlesIntersect ? "Yes" : "No");
            }
        }
        private static Circle GetCircle()
        {
            int[] data = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Point center = new Point() { X = data[0], Y = data[1] };
            Circle circle = new Circle() { Center = center, Radius = data[2] };
            return circle;
        }

        class Circle
        {
            public Point Center { get; set; }
            public int Radius { get; set; }
        }

        class Point
        {
            public int X { get; set; }
            public int Y { get; set; }

            public double DistanceTo(Point p)
            {
                double deltaX = Math.Abs(X - p.X);
                double deltaY = Math.Abs(Y - p.Y);
                return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            }
        }
    }
}

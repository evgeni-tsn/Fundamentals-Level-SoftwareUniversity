using System;
using System.Linq;

namespace _04.DistancePoints
{
    /* 
     * Write a method to calculate the distance between two points p1 {x1, y1} and p2 {x2, y2}. 
     * Write a program to read two points (given as two integers) and print the Euclidean distance between them.
     * You can check your solutions here: 
     * https://judge.softuni.bg/Contests/175/Objects-and-Classes-Lab
     */
    class DistancePoints
    {
        static void Main()
        {
            var first = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var second = Console.ReadLine().Split().Select(double.Parse).ToArray();
            double x1 = first[0];
            double y1 = first[1];
            double x2 = second[0];
            double y2 = second[1];

            Console.WriteLine("{0:f3}",Math.Sqrt(
                Math.Pow(x2-x1,2)+
                Math.Pow(y2-y1,2)
                ));
        }
    }
}

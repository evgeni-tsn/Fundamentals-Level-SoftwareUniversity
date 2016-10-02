using System;
namespace _02.CircleArea
{
    class CircleArea
    {
        /* You can check this code here:
        * https://judge.softuni.bg/Contests/Practice/Index/171#1
        */
        static void Main()
        {
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"{Math.PI*radius*radius:F12}");
        }
    }
}

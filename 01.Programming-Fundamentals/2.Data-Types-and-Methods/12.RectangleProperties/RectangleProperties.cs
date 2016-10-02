using System;

namespace _12.RectangleProperties
{
    /* 
    * Create a program to calculate rectangle’s perimeter, area and diagonal by given its width and height.
    * You can check this code here:
    * https://judge.softuni.bg/Contests/Practice/Index/206#11
    */
    class RectangleProperties
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine(2 * (width + height));
            Console.WriteLine(width * height);
            Console.WriteLine(Math.Sqrt(width * width + height * height));
        }
    }
}

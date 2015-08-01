using System;
using System.Runtime.CompilerServices;

class PointInCircl
{
    //Write an expression that checks if given point (x,  y) is inside a circle K({0, 0}, 2). 
    //Algorithm: (x-center_x)^2 + (y - center_y)^2 < radius^2
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        const int radius = 2;
        bool isInside = (x - 0) * (x - 0) + (y - 0) * (y - 0) <= radius * radius;
        Console.WriteLine(isInside);
    }
}

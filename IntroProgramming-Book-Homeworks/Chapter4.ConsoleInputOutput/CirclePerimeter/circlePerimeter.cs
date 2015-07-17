using System;
class circlePerimeter
{
    static void Main()
    {
        int radius = int.Parse(Console.ReadLine());

        double perimeter = 2*Math.PI*radius;
        double area = Math.PI*radius*radius;

        Console.WriteLine(perimeter);
        Console.WriteLine(area);
    }
}
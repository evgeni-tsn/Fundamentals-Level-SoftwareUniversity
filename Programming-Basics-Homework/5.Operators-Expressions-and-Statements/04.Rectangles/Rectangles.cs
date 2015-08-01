using System;
class Rectangles
{
    //Write an expression that calculates rectangle’s perimeter and area by given width and height. 
    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        double perimeter = 2 * width + 2 * height;
        double area = width*height;

        Console.WriteLine(perimeter);
        Console.WriteLine(area);
    }
}

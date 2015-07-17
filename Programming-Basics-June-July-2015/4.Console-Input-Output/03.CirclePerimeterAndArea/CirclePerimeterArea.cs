using System;
class CirclePerimeterArea
{
    //Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point. 
    static void Main()
    {
        double r = double.Parse(Console.ReadLine());
        double perimeter = 2*r*Math.PI;
        double area = r*r*Math.PI;

        Console.WriteLine("Perimeter: {0:f2}", perimeter);
        Console.WriteLine("Area: {0:f2}",area);
    }
}

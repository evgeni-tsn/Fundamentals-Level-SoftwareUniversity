using System;
class insideOutside
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double radius = 1.5;

        bool insideCircle = ((x - 1) * (x - 1)) + ((y - 1) * (y - 1)) <= radius * radius;

        bool outsideRectangle = ((x > -1 || x < 6) && (y > -1 || y <= 1));

        if (x==0||y==0)
        {
            Console.WriteLine(false);
        }
        else if (insideCircle && outsideRectangle)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}

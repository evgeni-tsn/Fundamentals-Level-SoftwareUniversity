using System;
class InsideCircleOutsideRectangle
{
    //Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2). 
    static void Main()
    {
        //input
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        //constants
        const double radius = 1.5;

        //algorith
        bool insideCircle = (x - 1) * (x - 1) + (y - 1) * (y - 1) <= radius * radius;
        bool insideRectangle = ((x >= -1) && (x <= 5)) && ((y >= -1) && (y <= 1));
        
        //result
        bool result = (insideCircle && !insideRectangle);
        
        //formatting output
        if (result)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}

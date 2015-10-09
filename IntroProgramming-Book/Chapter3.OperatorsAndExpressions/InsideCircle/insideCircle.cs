using System;
class insideCircle
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int radius = 5;
        int centerx = 0;
        int centery = 0;

        //(x-center_x)^2 + (y - center_y)^2 < radius^2
        int inCircle = ((x - centerx)*(x - centerx)) + ((y - centery)*(y - centery));
        
        if (inCircle<radius*radius)
        {
            Console.WriteLine("Inside");
        }
        else
        {
            Console.WriteLine("Outside");
        }
    }
}

using System;
class sqarePerAndArea
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        int perimeter = 2*(a + b);
        int area = a*b;

        Console.WriteLine(perimeter);
        Console.WriteLine(area);
    }
}
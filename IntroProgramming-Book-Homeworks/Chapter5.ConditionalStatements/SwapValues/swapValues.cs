using System;
class swapValues
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int biggestNum = a;

        if (b>a)
        {
            biggestNum = b;
            Console.WriteLine(biggestNum);
            Console.WriteLine(a);
        }
        else
        {
            Console.WriteLine(biggestNum);
            Console.WriteLine(b);
        }
    }
}

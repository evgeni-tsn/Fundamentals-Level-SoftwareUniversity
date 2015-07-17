using System;
class swapValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        //int c = a;

        a = a + b;
        b = a - b;
        a = a - b;

        //a = b;
        //b = c;
        Console.WriteLine(a);
        Console.WriteLine(b);

    }
}

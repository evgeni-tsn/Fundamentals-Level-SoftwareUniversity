using System;
using System.Text;

class icocelesTriangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        char symbol = '\u00A9';

        Console.WriteLine(" " + " " + " " + symbol + " " + " ");
        Console.WriteLine(" " + " " + symbol + " " + symbol + " ");
        Console.WriteLine(" " + symbol + " " + " " + " " + symbol);
        Console.WriteLine(symbol + " " + symbol + " " + symbol + " " + symbol);
    }
}

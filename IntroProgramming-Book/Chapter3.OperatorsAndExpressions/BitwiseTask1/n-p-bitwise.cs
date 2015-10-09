using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int change = 1;
        int mask = change << p;

        Console.WriteLine((n & mask) != 0 ? 1 : 0);
    }
}

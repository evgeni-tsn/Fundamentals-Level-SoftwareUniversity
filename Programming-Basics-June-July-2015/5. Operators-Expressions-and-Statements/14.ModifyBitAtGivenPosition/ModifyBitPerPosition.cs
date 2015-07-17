using System;
class ModifyBitPerPosition
{
    //We are given an integer number n, a bit value v (v=0 or 1) and a position p. Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n. 
    static void Main()
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter position: ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Enter value of bit for this ({0}) positon: ",p);
        int v = int.Parse(Console.ReadLine());

        if (v==0)
        {
            int mask = ~(1 << p);
            int result = n & mask;
            Console.WriteLine(result);
        }
        else if(v==1)
        {
            int mask = 1 << p;
            int result = n | mask;
            Console.WriteLine(result);
        }
    }
}

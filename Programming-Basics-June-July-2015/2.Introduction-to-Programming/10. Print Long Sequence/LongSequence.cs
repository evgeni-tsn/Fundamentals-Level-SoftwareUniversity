using System;
class LongSequence
{
    static void Main()
    {
        for (int i = 2; i <= 1001; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write("{0},", i);
            }
            else
            {
                Console.Write("-{0},", i);
            }
        }
        Console.WriteLine();
    }
}
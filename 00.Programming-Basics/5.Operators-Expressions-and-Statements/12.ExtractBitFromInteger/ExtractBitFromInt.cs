using System;
class ExtractBitFromInt
{
    //Write an expression that extracts from given integer n the value of given bit at index p. 
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());

        n = n >> p;
        int bit = n & 1;
        Console.WriteLine(bit);
    }
}
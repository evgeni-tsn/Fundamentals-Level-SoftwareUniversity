using System;
class between2Nums
{
    static void Main()
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int counter = 0;

        for (int i = first; i <= second; i++)
        {
            
            if (i%5==0)
            {
                counter++;
            }
        }
        Console.WriteLine(counter);
    }
}

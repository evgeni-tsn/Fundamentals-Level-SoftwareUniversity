using System;
class highestOf5
{
    static void Main()
    {

        int biggestNum = int.MinValue;
        for (int i = 0; i < 5; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (num>biggestNum)
            {
                biggestNum = num;
            }
        }
        Console.WriteLine(biggestNum);
    }
}

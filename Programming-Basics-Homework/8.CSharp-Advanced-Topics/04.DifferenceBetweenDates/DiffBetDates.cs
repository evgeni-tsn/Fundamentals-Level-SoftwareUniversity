using System;
using System.Globalization;

class DiffBetDates
{
    //Write a program that enters two dates in format dd.MM.yyyy and returns the number of days between them. 
    static void Main()
    {
        Console.Write("First date: ");
        string dateStart = Console.ReadLine();
        Console.Write("Second date: ");
        string dateEnd = Console.ReadLine();
        DateTime start = DateTime.ParseExact(dateStart, "d.M.yyyy", CultureInfo.InvariantCulture);
        DateTime end = DateTime.ParseExact(dateEnd, "d.M.yyyy", CultureInfo.InvariantCulture);
        int count = 0;
        if (start > end)
        {
            for (DateTime i = end; i <= start; i = i.AddDays(1))
            {
                if (i == start)
                {
                    Console.WriteLine("Days between: {0} days", -count);
                    return;
                }
                else
                {
                    count++;
                }
            }
        }
        else
        {
            for (DateTime i = start; i <= end; i = i.AddDays(1))
            {
                if (i == end)
                {
                    Console.WriteLine("Days between: {0} days", count);
                    return;
                }
                else
                {
                    count++;
                }
            }
        }
    }
}

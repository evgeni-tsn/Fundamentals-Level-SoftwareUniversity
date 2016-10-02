using System;
using System.Globalization;

namespace WeekendsBetweenTwoDates
{
    // You can check this code in the judge contest:
    // https://judge.softuni.bg/Contests/Practice/Index/204#0

    class WeekendsBetweenDates
    {
        static void Main()
        {
            var startDate = DateTime.ParseExact(Console.ReadLine(),
                "d.M.yyyy", CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(Console.ReadLine(),
                "d.M.yyyy", CultureInfo.InvariantCulture);
            var holidaysCount = 0;
            for (var date = startDate; date <= endDate; date = date.AddDays(1))
            {
                if (date.DayOfWeek == DayOfWeek.Saturday ||
                    date.DayOfWeek == DayOfWeek.Sunday)
                {
                    holidaysCount++;
                }
            }
            Console.WriteLine(holidaysCount);
        }
    }
}

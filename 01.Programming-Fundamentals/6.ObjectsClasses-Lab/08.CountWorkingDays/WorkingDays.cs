using System;
using System.Collections.Generic;
using System.Globalization;

namespace _08.CountWorkingDays
{
    /* 
     * Write a program that reads two dates in format dd-MM-yyyy and prints 
     * the number of working days between these two dates inclusive. 
     * Consider that official holidays are New Year Eve (1 Jan), 
     * Liberation Day (3 March), 
     * Worker’s day (1 May), 
     * Saint George’s Day (6 May), 
     * Saints Cyril and Methodius Day (24 May), 
     * Unification Day (6 Sept), 
     * Independence Day (22 Sept), 
     * National Awakening Day (1 Nov), 
     * Christmas (24, 25, 26 Dec). 
     * Consider also leap years have 1 extra day.
     * You can check your solutions here: 
     * https://judge.softuni.bg/Contests/175/Objects-and-Classes-Lab
     */
    class WorkingDays
    {
        static void Main()
        {
            var holidays = new List<DateTime>()
            {
                new DateTime(2015, 1, 1),
                new DateTime(2015, 3, 3),
                new DateTime(2015, 5, 1),
                new DateTime(2015, 5, 6),
                new DateTime(2015, 5, 24),
                new DateTime(2015, 9, 6),
                new DateTime(2015, 9, 22),
                new DateTime(2015, 11, 1),
                new DateTime(2015, 12, 24),
                new DateTime(2015, 12, 25),
                new DateTime(2015, 12, 26),
            };
            var startDate = DateTime.ParseExact(Console.ReadLine(),
                "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(Console.ReadLine(),
                "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var workDays = 0;
            for (var date = startDate; date <= endDate; date = date.AddDays(1))
            {
                if (date.DayOfWeek == DayOfWeek.Sunday || date.DayOfWeek == DayOfWeek.Saturday)
                {
                    workDays--;
                }
                else
                {
                    foreach (var holiday in holidays)
                    {
                        if (holiday.Month == date.Month && holiday.Day == date.Day)
                        {
                            workDays--;
                        }
                    }
                }
                workDays++;
            }
            Console.WriteLine(workDays);
        }
    }
}

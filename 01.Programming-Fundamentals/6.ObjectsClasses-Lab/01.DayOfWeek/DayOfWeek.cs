using System;
using System.Globalization;

namespace _01.DayOfWeek
{
    /* 
     * You are given a date in format day-month-year. Calculate and print the day of week in English.
     * Print the resulting string on the console.
     * You can check your solutions here: 
     * https://judge.softuni.bg/Contests/175/Objects-and-Classes-Lab
     */
    class DayOfWeek
    {
        static void Main()
        {
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "d-M-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(date.DayOfWeek);
        }
    }
}

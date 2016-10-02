using System;

namespace _01.CenturiesToMinutes
{
    class CenturiesToMinutes
    {
        //Write program to enter an integer number of centuries
        //and convert it to years, days, hours and minutes.
        static void Main()
        {
            decimal centuries = decimal.Parse(Console.ReadLine());
            decimal years = centuries * 100;
            decimal days = years * 365.2422M;
            decimal hours = (int)days * 24;
            decimal minutes = hours * 60;

            Console.WriteLine((int)centuries);
            Console.WriteLine((int)years);
            Console.WriteLine((int)days);
            Console.WriteLine((int)hours);
            Console.WriteLine((int)minutes);
        }
    }
}
using System;

namespace _10.CenturiesNanoseconds
{
    /* 
    * Write program to enter an integer number of centuries and convert it to years, days, hours, minutes, seconds, milliseconds, microseconds, nanoseconds
    * You can check this code here:
    * https://judge.softuni.bg/Contests/Practice/Index/206#9
    */
    class CenturiesNanoseconds
    {
        static void Main()
        {
            ulong centuries = ulong.Parse(Console.ReadLine());
            ulong years = centuries * 100;
            ulong days = (ulong)(years * 365.2422);
            ulong hours =days * 24;
            ulong minutes = hours * 60;
            ulong seconds = minutes * 60;
            ulong miliSeconds = seconds * 1000;
            ulong microSeconds = miliSeconds * 1000;
            decimal nanoSeconds = (decimal)microSeconds * 1000;

            Console.WriteLine(centuries);
            Console.WriteLine(years);
            Console.WriteLine(days);
            Console.WriteLine(hours);
            Console.WriteLine(minutes);
            Console.WriteLine(seconds);
            Console.WriteLine(miliSeconds);
            Console.WriteLine(microSeconds);
            Console.WriteLine(nanoSeconds);
        }
    }
}
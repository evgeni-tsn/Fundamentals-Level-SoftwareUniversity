using System;
namespace _1.DayOfWeek
{
    /* 
     * Enter a day number [1…7] and print the day name (in English) or “Invalid Day!”.
     * You can check this code here:
     * https://judge.softuni.bg/Contests/Practice/Index/172#0
     */
    class DayOfWeek
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            switch (n)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid Day!");
                    break;
            }
        }
    }
}

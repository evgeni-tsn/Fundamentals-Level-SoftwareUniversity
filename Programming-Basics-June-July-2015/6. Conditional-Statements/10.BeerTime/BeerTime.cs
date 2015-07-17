using System;
class BeerTime
{
//A beer time is after 1:00 PM and before 3:00 AM. Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) and prints “beer time” or “non-beer time” according to the definition above or “invalid time” if the time cannot be parsed. Note that you may need to learn how to parse dates and times.
    private static void Main()
    {
        DateTime time = DateTime.Parse(Console.ReadLine());
        string sign = time.ToString("tt");
        if (sign == "AM")
        {
            if (time.Hour>=3 && time.Minute>=00 && time.Minute<60)
            {
                Console.WriteLine("non-beer time");
            }
            else
            {
                Console.WriteLine("beer time");
            }
        }
        else if (sign == "PM")
        {
            if (time.Hour-12>=1)
            {
                Console.WriteLine("beer time");
            }
            else
            {
                Console.WriteLine("non-beer time");
            }
        }
    }
}
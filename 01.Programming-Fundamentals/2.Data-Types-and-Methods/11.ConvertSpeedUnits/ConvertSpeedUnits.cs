using System;
namespace _11.ConvertSpeedUnits
{
    /* 
    * Create a program to ask the user for a distance (in meters) and the time taken (as three numbers: hours, minutes, seconds), and display the speed, in meters per second, kilometers per hour and miles per hour. 
      Assume 1 mile = 1609 meters
    * You can check this code here:
    * https://judge.softuni.bg/Contests/Practice/Index/206#10
    */

    class ConvertSpeedUnits
    {
        static void Main()
        {
            float distanceInMeters = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());
            float hoursToSecond = hours * 60 * 60;
            float minutesToSecond = minutes * 60;
            float totalSeconds = hoursToSecond + minutesToSecond + seconds;
            float metersToKm = distanceInMeters / 1000;
            float totalHours = totalSeconds / 60 / 60;
            float oneMileInMeters = 1609;
            float kmToMiles = distanceInMeters / oneMileInMeters;

            Console.WriteLine("{0}", distanceInMeters / totalSeconds);
            Console.WriteLine("{0}", metersToKm / totalHours);
            Console.WriteLine("{0}", kmToMiles / totalHours);


        }
    }
}

using System;
namespace _04.Elevator
{
    class Elevator
    {
        /* You can check this code here:
        * https://judge.softuni.bg/Contests/Practice/Index/171#3
        */
        static void Main()
        {
            double people = double.Parse(Console.ReadLine());
            double capacity = double.Parse(Console.ReadLine());

            Console.WriteLine(Math.Ceiling(people / capacity));
        }
    }
}

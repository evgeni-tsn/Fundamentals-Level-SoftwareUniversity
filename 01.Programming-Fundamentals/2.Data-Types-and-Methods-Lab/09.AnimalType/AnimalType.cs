using System;
namespace _09.AnimalType
{
    /* You can check this code here:
    * https://judge.softuni.bg/Contests/Practice/Index/171#8
    */
    class AnimalType
    {
        static void Main()
        {
            string animal = Console.ReadLine();
            switch (animal)
            {
                case "dog":
                    Console.WriteLine("mammal");
                    break;
                case "crocodile":
                case "tortoise":
                case "snake":
                    Console.WriteLine("reptile");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}

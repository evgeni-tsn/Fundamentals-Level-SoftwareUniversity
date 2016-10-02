using System;

namespace _10.FilledSquare
{
    /* You can check this code here:
    * https://judge.softuni.bg/Contests/Practice/Index/171#9
    */
    class FilledSquare
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            string topBottom = new string('-', number * 2);
            Console.WriteLine(topBottom);
            for (int i = 0; i < number - 2; i++)
            {
                Console.Write("-");
                for (int j = 0; j < (number * 2 - 2) / 2; j++)
                {
                    Console.Write("\\");
                    Console.Write("/");
                }
                Console.Write("-");
                Console.WriteLine();
            }
            Console.WriteLine(topBottom);
        }
    }
}

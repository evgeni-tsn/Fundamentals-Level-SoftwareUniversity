using System;
using System.Linq;

namespace _05.CompareCharArrays
{
    /* 
    * Compare two char arrays lexicographically (letter by letter) and 
    * prints them in correct order each on separate line.
    * You can check this code here:
    * https://judge.softuni.bg/Contests/Practice/Index/207#4
    */
    class CompareCharArrays
    {
        static void Main()
        {
            var first = Console.ReadLine().Split().ToList();
            var second = Console.ReadLine().Split().ToList();

            if (first.Count < second.Count)
            {
                Console.WriteLine(string.Join("", first));
                Console.WriteLine(string.Join("", second));
            }
            else if (second.Count < first.Count)
            {
                Console.WriteLine(string.Join("", second));
                Console.WriteLine(string.Join("", first));
            }
            else
            {
                bool isSecond = false;
                for (int i = 0; i < first.Count; i++)
                {
                    if (first[i] != second[i] && first[i].CompareTo(second[i]) > 0)
                    {
                        isSecond = true;
                    }
                }

                if (isSecond)
                {
                    Console.WriteLine(string.Join("", second));
                    Console.WriteLine(string.Join("", first));
                }
                else
                {
                    Console.WriteLine(string.Join("", first));
                    Console.WriteLine(string.Join("", second));
                }
            }
        }
    }
}

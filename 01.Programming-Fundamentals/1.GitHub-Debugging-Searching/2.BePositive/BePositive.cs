using System;
using System.Collections.Generic;

namespace _2.BePositive
{
    /* You can check this problem in the judge contest:
    * https://judge.softuni.bg/Contests/Practice/Index/203#1 */
    class BePositive
    {
        public static void Main()
        {
            int countSequences = int.Parse(Console.ReadLine());

            for (int i = 0; i < countSequences; i++)
            {
                string[] input = Console.ReadLine().Trim().Split(' ');
                var numbers = new List<int>();

                foreach (string item in input)
                {
                    if (!item.Equals(string.Empty))
                    {
                        int num = int.Parse(item);
                        numbers.Add(num);
                    }
                }

                bool found = false;

                for (int j = 0; j < numbers.Count; j++)
                {
                    int currentNum = numbers[j];

                    if (currentNum >= 0)
                    {
                        if (found)
                        {
                            Console.Write(" ");
                        }

                        Console.Write(currentNum);

                        found = true;
                    }
                    else
                    {
                        if (j+1 >= numbers.Count)
                        {
                            break;
                        }
                        currentNum += numbers[j + 1];

                        if (currentNum >= 0)
                        {
                            if (found)
                            {
                                Console.Write(" ");
                            }

                            Console.Write(currentNum);

                            found = true;
                        }
                        j++;
                    }
                }


                if (!found)
                {
                    Console.Write("(empty)");
                }
                Console.WriteLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.ArrayManipulator
{
    /*
     * Write a program that reads an array of integers from the console and set of commands and executes them on the array. 
     * The commands are as follows:
        •add <index> <element> - adds element at the given index
        •addMany <index> <element 1> <element 2> … <element n> - adds set of elements at the given index
        •contains <element> - prints index of the element if exists in the array or -1 
        if the element is not found
        •remove <index> - removes element at given index
        •shift <positions> - shifts every element of the array the number of positions to the left. 
        •sumPairs -> sums elements in the array of pairs. 
        •print – stop receiving more commands and print the last state of the array.
     * You can check your solutions here: 
     * https://judge.softuni.bg/Contests/208/Lists-and-Matrices-Exercises
     */
    class ArrayManipulator
    {
        static List<int> list = new List<int>();

        static void Main()
        {
            list = Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var command = Console.ReadLine();

            while (command != "print")
            {
                var splitted = command.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                switch (splitted[0])
                {
                    case "add":
                        AddCommand(splitted[1], splitted[2]);
                        break;
                    case "addMany":
                        AddManyCommand(splitted);
                        break;
                    case "contains":
                        ContainsCommand(splitted[1]);
                        break;
                    case "remove":
                        RemoveCommand(splitted[1]);
                        break;
                    case "shift":
                        ShiftCommand(splitted[1]);
                        break;
                    case "sumPairs":
                        SumPairsCommand();
                        break;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine("[" + string.Join(", ", list) + "]");
        }

        private static void SumPairsCommand()
        {
            List<int> summedSequence = new List<int>((list.Count + 1 / 2) + 2);
            for (int i = 0; i < list.Count - 1; i += 2)
            {
                summedSequence.Add(list[i] + list[i + 1]);
            }
            if (list.Count % 2 == 1)
            {
                summedSequence.Add(list[list.Count - 1]);
            }

            list = summedSequence;
        }

        private static void ShiftCommand(string positions)
        {
            for (int i = 0; i < int.Parse(positions); i++)
            {
                int oldValue = list[0];
                for (int index = 0; index < list.Count - 1; index++)
                {
                    list[index] = list[index + 1];
                }

                list[list.Count - 1] = oldValue;
            }
        }

        private static void RemoveCommand(string index)
        {
            list.RemoveAt(int.Parse(index));
        }

        private static void ContainsCommand(string element)
        {
            if (list.Contains(int.Parse(element)))
            {
                Console.WriteLine(list.IndexOf(int.Parse(element)));
            }
            else
            {
                Console.WriteLine(-1);
            }
        }

        private static void AddManyCommand(string[] items)
        {
            List<int> temp = new List<int>();
            for (int i = 2; i < items.Length; i++)
            {
                temp.Add(int.Parse(items[i]));
            }
            list.InsertRange(int.Parse(items[1]), temp);
        }

        private static void AddCommand(string index, string element)
        {
            list.Insert(int.Parse(index), int.Parse(element));
        }
    }
}

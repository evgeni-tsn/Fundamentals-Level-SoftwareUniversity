using System;
using System.Linq;

class SubsetSums
{
    //Write a program that reads from the console a number N and an array of integers given on a single line. 
    //Your task is to find all subsets within the array which have a sum equal to N and print them on the console
    //(the order of printing is not important). Find only the unique subsets by filtering out repeating numbers
    //first. In case there aren't any subsets with the desired sum, print "No matching subsets."

    static void Main()
    {
        bool solutionFound = false;
        int targetSum = int.Parse(Console.ReadLine());
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).Distinct().ToArray();
        var subsets = from m in Enumerable.Range(0, 1 << numbers.Length)
                      select
                            from i in Enumerable.Range(0, numbers.Length)
                            where (m & (1 << i)) != 0
                            select numbers[i];

        foreach (var item in subsets)
        {
            if (item.Sum() == targetSum)
            {
                Console.WriteLine("{0} = {1}", String.Join(" + ", item), targetSum);
                solutionFound = true;
            }

        }
        if (solutionFound == false)
        {
            Console.WriteLine("No matching subsets.");
        }
    }
}
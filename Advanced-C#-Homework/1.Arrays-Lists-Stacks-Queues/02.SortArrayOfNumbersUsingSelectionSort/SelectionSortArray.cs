using System;
using System.Linq;
using System.Net.NetworkInformation;

class SelectionSortArray
{
    //Write a program to sort an array of numbers and then print them back on the console. 
    //The numbers should be entered from the console on a single line, separated by a space. 
    //Refer to the examples for problem 1.

    static void Main()
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

        SelectionSort(input);

        Console.WriteLine(String.Join(" ", input));
    }

    private static void SelectionSort(int[] arr)
    {
        int minPos = 0;
        int min = 0;
        for (int i = 0; i < arr.Length-1; i++)
        {
            min = arr[i];
            minPos = i;
            for (int j = i+1; j < arr.Length; j++)
            {
                if (arr[j]<min)
                {
                    min = arr[j];
                    minPos = j;
                }
            }
            if (minPos!=i)
            {
                int buff = arr[i];
                arr[i] = arr[minPos];
                arr[minPos] = buff;
            }
        }
    }
}

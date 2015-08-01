using System;
class LargerThanNeighbours
{
    //Write a method that checks if the element at given position in a given array of integers 
    //is larger than its two neighbours (when such exist).
    static void Main()
    {
        int[] numbers = { 1, 3, 4, 5, 1, 0, 5 };

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(IsLargerThanNeighbours(numbers, i));
        }
    }

    static bool IsLargerThanNeighbours(int[] arr, int index)
    {
        bool isLarger = false;
        if (index>0)
        {
            if (index < arr.Length-1)
            {
                isLarger = (arr[index] > arr[index - 1] && arr[index] > arr[index+1]);
            }
            else
            {
                isLarger = (arr[index] > arr[index - 1]);
            }
        }
        else
        {
            isLarger = (arr[index] > arr[index + 1]);
        }
        return isLarger;
    }
}

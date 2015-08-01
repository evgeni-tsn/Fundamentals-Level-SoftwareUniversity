using System;
class FirstLargerThanNeighbours
{
    //Write a method that returns the index of the first element in array that is larger
    //than its neighbours, or -1 if there's no such element. 
    //Use the method from the previous exercise in order to re.
    static void Main()
    {
        int[] sequenceOne = {1, 3, 4, 5, 1, 0, 5};
        int[] sequenceTwo = {1, 2, 3, 4, 5, 6, 6};
        int[] sequenceThree = {1, 1, 1};

        Console.WriteLine(FirstLargerThanItsNeighbours(sequenceOne));
        Console.WriteLine(FirstLargerThanItsNeighbours(sequenceTwo));
        Console.WriteLine(FirstLargerThanItsNeighbours(sequenceThree));
    }
    static int FirstLargerThanItsNeighbours(int[] arr)
    {
        int largerIndex = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (i > 0)
            {
                if (i < arr.Length - 1)
                {
                    if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
                    {
                        largerIndex = i;
                    }
                    //isLarger = (arr[index] > arr[index - 1] && arr[index] > arr[index + 1]);
                }
                else
                {
                    if (arr[i] > arr[i - 1])
                    {
                        largerIndex = i;
                    }
                    //isLarger = (arr[index] > arr[index - 1]);
                }
            }
            else
            {
                largerIndex = i;
                //isLarger = (arr[index] > arr[index + 1]);
            }
            if (largerIndex!=0)
            {
                break;
            }
        }
        if (largerIndex==0)
        {
            largerIndex = -1;
        }
        return largerIndex;
    }
}
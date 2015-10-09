using System;
class compareArrays
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] firstArray = new int[n];
        int[] secondArray = new int[n];
        bool areSame = false;

        for (int i = 0; i < firstArray.Length; i++)
        {
            firstArray[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < secondArray.Length; i++)
        {
            secondArray[i] = int.Parse(Console.ReadLine());
        }
        if (firstArray.Length == secondArray.Length)
        {
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    areSame = true;
                }
                
            }
        }
        Console.WriteLine(areSame);

    }
}
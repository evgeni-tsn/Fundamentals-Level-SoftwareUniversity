using System;
class OddEvenProduct
{
    //You are given n integers (given in a single line, separated by a space). Write a program that checks whether the product of the odd elements is equal to the product of the even elements. Elements are counted from 1 to n, so the first element is odd, the second is even, etc. 
    static void Main()
    {
        string[] nums = Console.ReadLine().Split();

        int oddSum = 1;
        int evenSum = 1;

        for (int i = 0; i < nums.Length; i++)
        {
            int num = int.Parse(nums[i]);

            if (i%2==0)
            {
                oddSum *= num;
            }
            else
            {
                evenSum *= num;
            }
        }
        if (oddSum==evenSum)
        {
            Console.WriteLine("Yes");
            Console.WriteLine("Product = {0}",oddSum);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("odd_product = {0}",oddSum);
            Console.WriteLine("even_product = {0}",evenSum);
        }


    }
}
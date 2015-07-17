using System;
class Sum5nums
{
    //Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum
    static void Main()
    {
        string[] nums = Console.ReadLine().Split();

        double a = double.Parse(nums[0]);
        double b = double.Parse(nums[1]);
        double c = double.Parse(nums[2]);
        double d = double.Parse(nums[3]);
        double e = double.Parse(nums[4]);

        Console.WriteLine(a+b+c+d+e);
    }
}
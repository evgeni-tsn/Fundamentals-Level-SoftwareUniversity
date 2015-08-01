using System;
using System.Linq;

class NumberCalculation
{
    //Write methods to calculate the minimum, maximum, average, sum and product of a given set of numbers.
    //Overload the methods to work with numbers of type double and decimal.
    static void Main()
    {
        Console.Write("Please, enter a sequence of space-separated integers: ");
        int[] intNumbers = Console.ReadLine().Trim().Split().Select(p => int.Parse(p)).ToArray();
        Console.WriteLine("Integer array minimum: {0}", Minimum(intNumbers));
        Console.WriteLine("Integer array maximum: {0}", Maximum(intNumbers));
        Console.WriteLine("Integer array average: {0}", Average(intNumbers));
        Console.WriteLine("Integer array sum: {0}", Sum(intNumbers));
        Console.WriteLine("Integer array product: {0}", Product(intNumbers));

        Console.Write("Please, enter a sequence of space-separated doubles: ");
        double[] doubleNumbers = Console.ReadLine().Trim().Split().Select(p => double.Parse(p)).ToArray();
        Console.WriteLine("Double array minimum: {0}", Minimum(doubleNumbers));
        Console.WriteLine("Double array maximum: {0}", Maximum(doubleNumbers));
        Console.WriteLine("Double array average: {0}", Average(doubleNumbers));
        Console.WriteLine("Double array sum: {0}", Sum(doubleNumbers));
        Console.WriteLine("Double array product: {0}", Product(doubleNumbers));
    }

    static int Minimum(int[] array)
    {
        int min = int.MaxValue;
        for (int i = 0; i < array.Length; i++)
            if (array[i] < min)
                min = array[i];
        return min;
    }

    static int Maximum(int[] array)
    {
        int max = int.MinValue;
        for (int i = 0; i < array.Length; i++)
            if (array[i] > max)
                max = array[i];
        return max;

    }

    static double Average(int[] array)
    {
        if (array.Length == 0) return 0.0;
        return ((double)Sum(array)) / array.Length;
    }

    static int Sum(int[] array)
    {
        int result = 0;
        for (int i = 0; i < array.Length; i++)
        {
            result += array[i];
        }
        return result;
    }

    static int Product(int[] array)
    {
        int result = 1;
        for (int i = 0; i < array.Length; i++)
        {
            result *= array[i];
        }
        return result;
    }

    //double
    static double Minimum(double[] array)
    {
        double min = double.MaxValue;
        for (int i = 0; i < array.Length; i++)
            if (array[i] < min)
                min = array[i];
        return min;
    }

    static double Maximum(double[] array)
    {
        double max = double.MinValue;
        for (int i = 0; i < array.Length; i++)
            if (array[i] > max)
                max = array[i];
        return max;

    }

    static double Average(double[] array)
    {
        if (array.Length == 0) return 0.0;
        return ((double)Sum(array)) / array.Length;
    }

    static double Sum(double[] array)
    {
        double result = 0;
        for (int i = 0; i < array.Length; i++)
        {
            result += array[i];
        }
        return result;
    }

    static double Product(double[] array)
    {
        double result = 1;
        for (int i = 0; i < array.Length; i++)
        {
            result *= array[i];
        }
        return result;
    }

}
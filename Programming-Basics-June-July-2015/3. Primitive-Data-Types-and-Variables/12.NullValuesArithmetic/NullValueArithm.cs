using System;
class NullValueArithm
{
    //Create a program that assigns null values to an integer and to a double variable. Try to print these variables at the console. Try to add some number or the null literal to these variables and print the result.
    static void Main()
    {
        int? nullableI = null;
        double? nullableD = null;

        Console.WriteLine(nullableI);
        Console.WriteLine(nullableD);

        nullableI = nullableI + 4;
        nullableD = nullableD + 15;

        Console.WriteLine(nullableI);
        Console.WriteLine(nullableD);

        nullableI = nullableI + null;
        nullableD = nullableD + null;

        Console.WriteLine(nullableI);
        Console.WriteLine(nullableD);
    }
}
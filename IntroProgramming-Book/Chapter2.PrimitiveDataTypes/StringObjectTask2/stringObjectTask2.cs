using System;
class stringObjectTask2
{
    static void Main()
    {
        string one = "Hello";
        string two = "World";

        object three = one + " " + two;

        string final = (string)three;
        Console.WriteLine(final);
    }
}

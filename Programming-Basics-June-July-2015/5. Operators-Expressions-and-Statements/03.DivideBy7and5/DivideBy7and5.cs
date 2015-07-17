using System;
class DivideBy7and5
{
    //Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time. 
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        bool isDivisibleOn5and7 = (num % 5 == 0) && (num % 7 == 0);

        Console.WriteLine(isDivisibleOn5and7);
    }
}

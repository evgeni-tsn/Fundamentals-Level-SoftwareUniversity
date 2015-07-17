using System;
class ThirdDigit7
{
    //Write an expression that checks for given integer if its third digit from right-to-left is 7.
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        num /= 100;
        num %= 10;
        bool result = (num == 7);
        Console.WriteLine(result);
    }
}

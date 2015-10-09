using System;
class ThirdDigit
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        num /= 100;
        num %= 10;
        bool thirdDigit = num==7;
        Console.WriteLine(thirdDigit);
    }
}

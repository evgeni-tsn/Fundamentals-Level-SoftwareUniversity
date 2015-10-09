using System;
namespace FourDigitNum
{
class fourDigitNum
{
    static void Main()
    {
        Console.Write("Enter num: ");
        int num = int.Parse(Console.ReadLine());

        int a = (num / 1000) % 10;
        int b = (num / 100) % 10;
        int c = (num / 10) % 10;
        int d = (num / 1) % 10;

        Console.WriteLine("Sum is: "+(a+b+c+d));
        Console.WriteLine("Reversed: "+d+c+b+a);
        Console.WriteLine("Last digit in front: " + d + a + b + c);
        Console.WriteLine("Second and Third Digits Reversed " + a+c+b+d);
    }
}

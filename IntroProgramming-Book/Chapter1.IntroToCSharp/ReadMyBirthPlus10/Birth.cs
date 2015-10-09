using System;
class Birth
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        int howOld = int.Parse(Console.ReadLine());
        howOld += 10;
        Console.WriteLine("Your age after 10 years will be: "+howOld);
    }
}

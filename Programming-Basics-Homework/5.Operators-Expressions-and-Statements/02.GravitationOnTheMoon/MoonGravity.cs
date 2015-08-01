using System;
class MoonGravity
{
    //The gravitational field of the Moon is approximately 17% of that on the Earth. Write a program that calculates the weight of a man on the moon by a given weight on the Earth. 
    static void Main()
    {
        double weight = double.Parse(Console.ReadLine());
        double moonWeight = (17.0/100)*weight;
        Console.WriteLine("Weight on the moon: {0}",moonWeight);
    }
}

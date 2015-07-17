using System;
class PrimeCheck
{
    //Write an expression that checks if given positive integer number n (n ≤ 100) is prime (i.e. it is divisible without remainder only to itself and 1).
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        if (n<101)
        {
            bool prime = true;
            if (n < 2)
            {
                prime = false;
                Console.WriteLine(false);
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        prime = false;
                    }
                }
                Console.WriteLine(prime);
            }
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }
}
using System;
class primeChecker
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool prime = true;
        if (n < 2)
        {
            prime = false;
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
}

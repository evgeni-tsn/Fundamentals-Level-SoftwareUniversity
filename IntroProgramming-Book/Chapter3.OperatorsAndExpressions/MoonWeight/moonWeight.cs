using System;
class moonWeight
{
    static void Main()
    {
        int earthWeight = int.Parse(Console.ReadLine());

        double moonWeight = earthWeight*0.17;

        Console.WriteLine(moonWeight);
    }
}

using System;
class Program
{
    static void Main()
    {
        int intA;
        bool parseSuccess = false;
        do
        {
            string a = Console.ReadLine();
            parseSuccess = Int32.TryParse(a, out intA);
        }
        while (parseSuccess==false);

        int intB;
        parseSuccess = false;
        do
        {
            string a = Console.ReadLine();
            parseSuccess = Int32.TryParse(a, out intB);
        }
        while (parseSuccess == false);

        int intC;
        parseSuccess = false;
        do
        {
            string a = Console.ReadLine();
            parseSuccess = Int32.TryParse(a, out intC);
        }
        while (parseSuccess == false);

        int intD;
        parseSuccess = false;
        do
        {
            string a = Console.ReadLine();
            parseSuccess = Int32.TryParse(a, out intD);
        }
        while (parseSuccess == false);

        int intE;
        parseSuccess = false;
        do
        {
            string a = Console.ReadLine();
            parseSuccess = Int32.TryParse(a, out intE);
        }
        while (parseSuccess == false);

        Console.WriteLine(intA+intB+intC+intD+intE);
    }
}
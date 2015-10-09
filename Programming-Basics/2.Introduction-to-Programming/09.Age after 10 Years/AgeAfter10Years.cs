using System;
class AgeAfter10Years
{
    static void Main()
    {
        Console.Write("Enter Your Birthday: ");
        string input = Console.ReadLine();
        DateTime birthDate = Convert.ToDateTime(input);
        DateTime today = DateTime.Now;
        int birthYear = birthDate.Year;
        int todayYear = today.Year;
        TimeSpan diff = today.Subtract(birthDate);
        DateTime date0 = new DateTime().Add(diff);
        int yearsOld = date0.Year - 1;

        Console.WriteLine("Today we are: {0}", todayYear);
        Console.WriteLine("Your birthday year is: {0}", birthYear);
        Console.WriteLine("You are {0} years old.", yearsOld);
        Console.WriteLine("After 10 years you will be {0} years old", yearsOld + 10);
    }
}
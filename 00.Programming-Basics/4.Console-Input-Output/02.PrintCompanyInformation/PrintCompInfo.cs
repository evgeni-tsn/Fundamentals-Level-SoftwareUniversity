using System;
class PrintCompInfo
{
    //A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number. Write a program that reads the information about a company and its manager and prints it back on the console.
    static void Main()
    {
        Console.Write("Company name: ");
        string compName = Console.ReadLine();
        Console.Write("Company address: ");
        string compAddress = Console.ReadLine();
        Console.Write("Phone number: ");
        string phoneNum = Console.ReadLine();
        Console.Write("Fax number: ");
        string faxNum = Console.ReadLine();
        Console.Write("Website: ");
        string website = Console.ReadLine();
        Console.Write("Manager first name: ");
        string manFirstName = Console.ReadLine();
        Console.Write("Manager last name: ");
        string manLastName = Console.ReadLine();
        Console.Write("Manager age: ");
        string manAge = Console.ReadLine();
        Console.Write("Manager phone: ");
        string manPhone = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Output:");
        Console.WriteLine();

        Console.WriteLine(compName);
        Console.WriteLine("Address: " + compAddress);
        Console.WriteLine("Tel: " + phoneNum);
        Console.WriteLine("Fax: "+ faxNum);
        Console.WriteLine("Website: "+ website);
        Console.WriteLine("Manager: " + manFirstName+" "+manLastName+" (age: "+manAge+", "+"tel. "+manPhone+")");
        Console.WriteLine();
    }
}

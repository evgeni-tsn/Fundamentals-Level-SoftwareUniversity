using System;
class companyInfo
{
    static void Main()
    {
        string name = Console.ReadLine();
        string address = Console.ReadLine();
        string phoneNum = Console.ReadLine();
        string faxNum = Console.ReadLine();
        string website = Console.ReadLine();
        string managerFName = Console.ReadLine();
        string managerLName = Console.ReadLine();
        string managerPhoneNum = Console.ReadLine();

        Console.WriteLine("Company name: " + name);
        Console.WriteLine("Address: " + address);
        Console.WriteLine("Telephone: " + phoneNum);
        Console.WriteLine("Fax: " + faxNum);
        Console.WriteLine("Website: " + website);
        Console.WriteLine();
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("Manager name: " + managerFName +" "+ managerLName);
        Console.WriteLine("Manager phone: " + managerPhoneNum);
    }
}
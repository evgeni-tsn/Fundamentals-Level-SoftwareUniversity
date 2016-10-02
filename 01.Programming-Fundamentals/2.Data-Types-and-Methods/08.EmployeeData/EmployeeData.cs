using System;

namespace _08.EmployeeData
{
    /*A marketing company wants to keep record of its employees. Each record would have the following characteristics:
    •	First name
    •	Last name
    •	Age (0...100)
    •	Gender (m or f)
    •	Personal ID number (e.g. 8306112507)
    •	Unique employee number (27560000…27569999)
    Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.
    * You can check this code here:
    * https://judge.softuni.bg/Contests/Practice/Index/206#7
    */

    class EmployeeData
    {
        static void Main()
        {
            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            char sex = char.Parse(Console.ReadLine());
            long id = long.Parse(Console.ReadLine());
            long employeeId = long.Parse(Console.ReadLine());

            Console.WriteLine($"First name: {firstName}");
            Console.WriteLine($"Last name: {secondName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Gender: {sex}");
            Console.WriteLine($"Personal ID: {id}");
            Console.WriteLine($"Unique Employee number: {employeeId}");
        }
    }
}

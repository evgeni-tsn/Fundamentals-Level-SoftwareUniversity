using System;
class PlayWithIntDoubleString
{
    //Write a program that, depending on the user’s choice, inputs an int, double or string variable. If the variable is int or double, the program increases it by one. If the variable is a string, the program appends "*" at the end. Print the result at the console. Use switch statement. 
    static void Main()
    {
        int choose = int.Parse(Console.ReadLine());

        switch (choose)
        {
            case 1:
                Console.Write("Please enter an integer: ");
                int intN = int.Parse(Console.ReadLine());
                Console.WriteLine(intN+1);
                break;
            case 2:
                Console.Write("Please enter a double: ");
                double doubleN = double.Parse(Console.ReadLine());
                Console.WriteLine(doubleN+1);
                break;
            case 3:
                Console.Write("Please enter a string: ");
                string strN = Console.ReadLine();
                Console.WriteLine(strN+"*");
                break;
            default:
                Console.WriteLine("Invalid Input!");
                break;
        }
    }
}
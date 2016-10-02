using System;

namespace _01.PracticeIntegerNumbers
{
    /* 
     * Create a new C# project and create a program that assigns integer values to variables. Be sure that each value is stored in the correct variable type (try to find the most suitable variable type in order to save memory). Finally, you need to print all variables to the console.
     * You can check this code here:
     * https://judge.softuni.bg/Contests/Practice/Index/206#0
     */
    class IntegerNumbers
    {
        static void Main()
        {
            sbyte one = -100;
            byte two = 128;
            int three = -3540;
            int four = 64876;
            uint five = 2147483648;
            long six = -1141583228;
            long seven = -1223372036854775808;

            Console.WriteLine(one);
            Console.WriteLine(two);
            Console.WriteLine(three);
            Console.WriteLine(four);
            Console.WriteLine(five);
            Console.WriteLine(six);
            Console.WriteLine(seven);
        }
    }
}

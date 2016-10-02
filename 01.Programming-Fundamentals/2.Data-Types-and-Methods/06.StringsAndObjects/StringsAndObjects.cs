using System;
namespace _06.StringsAndObjects
{
    /* 
     * Declare two string variables and assign them with “Hello” and “World”. Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between). Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).
     * You can check this code here:
     * https://judge.softuni.bg/Contests/Practice/Index/206#5
     */
    class StringsAndObjects
    {
        static void Main()
        {
            string hello = "Hello";
            string world = "World";
            object hw = hello + " "+ world;
            string result = hw.ToString();
            Console.WriteLine(result);
        }
    }
}

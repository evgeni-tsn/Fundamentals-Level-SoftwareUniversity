using System;

namespace _16.PrintPartOfASCIITable
{
    /* 
    * Find online more information about ASCII (American Standard Code for Information Interchange) and write a program to prints part of the  ASCII table of characters at the console.  On the first line of input you will receive the char index you should start with and on the second line - the index of the last character you should print.
    * You can check this code here:
    * https://judge.softuni.bg/Contests/Practice/Index/206#15
    */
    class PrintASCII
    {
        static void Main()
        {
            int start = int.Parse(Console.ReadLine());
            int stop = int.Parse(Console.ReadLine());

            for (int i = start; i <= stop; i++)
            {
                Console.Write((char)i + " ");
            }
            Console.WriteLine();
        }
    }
}

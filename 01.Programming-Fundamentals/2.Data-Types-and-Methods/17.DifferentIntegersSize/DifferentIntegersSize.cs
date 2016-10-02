using System;

namespace _17.DifferentIntegersSize
{
    /* 
    * Given an input integer, you must determine which primitive data types are capable of properly storing that input.
    * You can check this code here:
    * https://judge.softuni.bg/Contests/Practice/Index/206#16
    */
    class DifferentIntegersSize
    {
        static void Main()
        {
            string input = Console.ReadLine();
            
            try
            {
                long parse = long.Parse(input);
                Console.WriteLine("{0} can be fitted in:", input);
            }
            catch (Exception)
            {
                Console.WriteLine("{0} can't be fitted anywhere", input);
            }
            try
            {
                sbyte sbt = sbyte.Parse(input);
                Console.WriteLine("* sbyte");
            }

            catch (OverflowException e)
            {

            }
            try
            {
                byte sbt = byte.Parse(input);
                Console.WriteLine("* byte");
            }

            catch (OverflowException e)
            {

            }
            try
            {
                short sbt = short.Parse(input);
                Console.WriteLine("* short");
            }

            catch (OverflowException e)
            {

            }
            try
            {
                ushort sbt = ushort.Parse(input);
                Console.WriteLine("* ushort");
            }

            catch (OverflowException e)
            {

            }
            try
            {
                int sbt = int.Parse(input);
                Console.WriteLine("* int");
            }

            catch (OverflowException e)
            {

            }
            try
            {
                uint sbt = uint.Parse(input);
                Console.WriteLine("* uint");
            }

            catch (OverflowException e)
            {

            }
            try
            {
                long sbt = long.Parse(input);
                Console.WriteLine("* long");
            }

            catch (OverflowException e)
            {

            }
        }
    }
}

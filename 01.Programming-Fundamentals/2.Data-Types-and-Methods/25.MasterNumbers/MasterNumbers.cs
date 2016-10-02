using System;

namespace _25.MasterNumbers
{
    /* 
    * A master number is an integer that holds the following properties:
        •	Is symmetric (palindrome), e.g. 5, 77, 282, 14341, 9553559
        •	Its sum of digits is divisible by 7, e.g. 77, 313, 464, 5225, 37173
        •	Holds at least one even digit, e.g. 232, 707, 6886, 87578
        Write a program to print all master numbers in the range [1…n]
    * You can check this code here:
    * https://judge.softuni.bg/Contests/Practice/Index/206#24
    */
    class MasterNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (IsPalindrom(i) && SumIsDivisible(i) && OneEven(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool OneEven(int i)
        {
            foreach (var item in i.ToString())
            {
                if (int.Parse(item.ToString()) % 2 == 0)
                {
                    return true;
                }
            }
            return false;
        }

        private static bool SumIsDivisible(int i)
        {
            int sum = 0;
            foreach (var item in i.ToString())
            {
                sum += int.Parse(item.ToString());
            }
            if (sum % 7 == 0)
            {
                return true;
            }
            return false;
        }

        public static bool IsPalindrom(int num)
        {
            string sNum = num.ToString();
            for (int i = 0; i < sNum.Length; i++)
                if (sNum[i] != sNum[sNum.Length - 1 - i]) return false;

            return true;
        }
    }
}

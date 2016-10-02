using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.SplitWordCasing
{
    /* 
     * Read a text, split it into words and distribute them into 3 lists.
        Lower-case words; Mixed-case words; Upper-case words
        Use the following separators: , ; : . ! ( ) “ ‘ \ / [ ] space
     * You can check this code here:
     * https://judge.softuni.bg/Contests/Practice/Index/173#3
     */
    class SplitWordCasing
    {
        static void Main()
        {
            List<string> input = Console.ReadLine()
            .Split(new char[] { ',', ';', ':', '.', '!', '(', ')', '\"', '\'', '/', '\\', '[', ']', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        
            var upper = new List<string>();
            var lower = new List<string>();
            var mixed = new List<string>();
            foreach (var word in input)
            {
                bool isAllUppercase = true;
                bool isAllLowercase = true;

                foreach (char ch in word)
                {
                    if (char.IsUpper(ch))
                    {
                        isAllLowercase = false;
                    }
                    else if (char.IsLower(ch))
                    {
                        isAllUppercase = false;
                    }
                    else
                    {
                        isAllUppercase = false;
                        isAllLowercase = false;
                    }
                }
                if (isAllUppercase)
                {
                    upper.Add(word);
                }
                else if (isAllLowercase)
                {
                    lower.Add(word);
                }
                else
                {
                    mixed.Add(word);
                }
            }
            Console.WriteLine("Lower-case: " + string.Join(", ", lower));
            Console.WriteLine("Mixed-case: " + string.Join(", ", mixed));
            Console.WriteLine("Upper-case: " + string.Join(", ", upper));
        }
    }
}

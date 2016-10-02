using System;
using System.Linq;

namespace _01.CensorYourEmailAddress
{
    /* 
     * You have some text that contains your email address. You’re sick of spammers, so you want to hide it. 
     * You decide to replace all characters in it with asterisks ('*') except the domain. 
     * Assume the email address will always be in format [username]@[domain]; 
     * you’ll need to replace username with asterisks of equal length and keep the domain unchanged. 
       In the example below, your email is given on the first line and the text is given on the second line.
       In order to accomplish the task, you may find these steps useful:
        •	Split the email into two parts – username and domain
        •	Create the replacement string by concatenating a string containing '*' 
        (with length equal to username.Length) with '@' and the domain.
        •	Replace all occurrences of your email with the replacement string.
     * You can check this code here:
     * https://judge.softuni.bg/Contests/209/Strings-Dictionaries-Lambda-and-LINQ-Exercises
     */
    class CensorEmail
    {
        static void Main()
        {
            string mail = Console.ReadLine();
            string[] splitted = mail.Split('@').ToArray();
            string replacementMail = new string('*', splitted[0].Length) + "@" + splitted[1];

            string text = Console.ReadLine();

            while (text.Contains(mail))
            {
                text = text.Replace(mail, replacementMail);
            }
            Console.WriteLine(text);
        }
    }
}

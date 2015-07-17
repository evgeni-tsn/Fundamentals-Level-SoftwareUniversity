using System;
using System.Collections.Generic;

class Program
{
    //Write a program that extracts and prints all URLs from given text. URL can be in only two formats:
    //•	http://something, e.g. http://softuni.bg, http://forums.softuni.bg, http://www.nakov.com 
    //•	www.something.domain, e.g.www.nakov.com, www.softuni.bg, www.google.com

    static void Main()
    {
        string input = Console.ReadLine();
        string[] stringSeparators = new string[] { " ", ". ", ", " };
        string[] text = input.Split(stringSeparators, StringSplitOptions.None);
        List<string> urls = new List<string>();

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i].Contains("http://") || text[i].Contains("www."))
            {
                urls.Add(text[i]);
            }
        }
        Console.WriteLine();

        foreach (var item in urls)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();
    }
}

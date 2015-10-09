using System;
using System.Collections.Generic;
using System.Linq;

class LongestWordinText
{
    //Write a program to find the longest word in a text.
    static void Main()
    {
        string[] text = Console.ReadLine().Split(new Char[] { ',', ' ', '.' });
        List<string> words = new List<string>(text);
        Console.WriteLine(words.OrderByDescending(s => s.Length).First());
    }
}
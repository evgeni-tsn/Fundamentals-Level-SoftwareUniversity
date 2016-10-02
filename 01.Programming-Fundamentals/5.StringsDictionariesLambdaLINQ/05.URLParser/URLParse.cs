using System;

namespace _05.URLParser
{
    /* 
     * Write a program that parses an URL in following format:
     * [protocol] ://[server]/[resource]
     * Print the resulting string on the console.
     * https://judge.softuni.bg/Contests/209/Strings-Dictionaries-Lambda-and-LINQ-Exercises
     */
    class URLParse
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] protocolSplit = input.Split(new string[] {"://"}, StringSplitOptions.RemoveEmptyEntries);
            string protocol = protocolSplit[0];
            string[] serverSplit = protocolSplit[1].Split('/');
            string server = serverSplit[0];
            string resourceSplit = string.Empty;
            for (int i = 1; i < serverSplit.Length; i++)
            {
                resourceSplit = resourceSplit + "/" + serverSplit[i];
            }

            Console.WriteLine("[protocol] = \"{0}\"", protocol);
            Console.WriteLine("[server] = \"{0}\"", server);
            Console.WriteLine("[resource] = \"{0}\"", resourceSplit.TrimStart('/'));
        }
    }
}

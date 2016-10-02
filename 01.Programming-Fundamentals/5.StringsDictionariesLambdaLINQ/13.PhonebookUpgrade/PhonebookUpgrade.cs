using System;
using System.Collections.Generic;

namespace _13.PhonebookUpgrade
{
    /* 
     * Add functionality to the phonebook from the previous task to print all contacts 
     * ordered lexicographically when receive the command “ListAll”.
     * Print the resulting string on the console.
     * https://judge.softuni.bg/Contests/209/Strings-Dictionaries-Lambda-and-LINQ-Exercises
     */
    class PhonebookUpgrade
    {
        static void Main()
        {
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();
            string input = "";
            while ((input = Console.ReadLine()) != "END")
            {
                string[] data = input.Split(' ');
                string name = String.Empty;
                switch (data[0])
                {
                    case "A":
                        name = data[1];
                        string phonenumber = data[2];
                        if (!phonebook.ContainsKey(name))
                            phonebook[name] = "";
                        phonebook[name] = phonenumber;
                        break;
                    case "S":
                        name = data[1];
                        Console.WriteLine(phonebook.ContainsKey(name)
                            ? string.Join(" -> ", name, phonebook[name])
                            : $"Contact {name} does not exist.");
                        break;
                    case "ListAll":
                        foreach (var phonebookPair in phonebook)
                            Console.WriteLine(string.Join(" -> ", phonebookPair.Key, phonebookPair.Value));
                        break;
                }
            }
        }
    }
}

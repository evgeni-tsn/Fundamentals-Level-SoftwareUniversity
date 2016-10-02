using System;
using System.Collections.Generic;

class Phonebook
{
    /* 
     * Write a program that receives some info from the console about people and their phone numbers.
     * Each entry should have just one name and one number (both of them strings). 
        On each line you will receive some of the following commands:
        •	A {name} {phone} – adds entry to the phonebook. 
        In case of trying to add a name that is already in the phonebook you should 
        change the existing phone number with the new one provided.
        •	S {name} – searches for a contact by given name and prints it in format
        "{name} -> {number}". 
        In case the contact isn't found, print "Contact {name} does not exist.".
        •	END – stop receiving more commands.

     * Print the resulting string on the console.
     * https://judge.softuni.bg/Contests/209/Strings-Dictionaries-Lambda-and-LINQ-Exercises
     */
    static void Main()
    {
        Dictionary<string, string> phonebook = new Dictionary<string, string>();
        string input = Console.ReadLine();
        while (input != "END")
        {
            string[] data = input.Split(' ');
            string name = data[1];
            switch (data[0])
            {
                case "A":
                {
                    string phonenumber = data[2];
                    if (!phonebook.ContainsKey(name))
                        phonebook[name] = "";
                    phonebook[name] = phonenumber;
                    break;
                }
                case "S":
                {
                    Console.WriteLine(phonebook.ContainsKey(name)
                        ? string.Join(" -> ", name, phonebook[name])
                        : $"Contact {name} does not exist.");
                    break;
                }
            }
            input = Console.ReadLine();
        }
    }
}


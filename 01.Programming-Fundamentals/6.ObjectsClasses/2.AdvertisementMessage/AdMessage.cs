using System;

namespace _2.AdvertisementMessage
{
    /* 
     * Write a program that generate random fake advertisement message to extol some product. 
     * The messages must consist of 4 parts: laudatory phrase + event + author + city. 
     * Use the following predefined parts:
        •	Phrases – {“Excellent product.”, “Such a great product.”, 
        “I always use that product.”, “Best product of its category.”, 
        “Exceptional product.”, “I can’t live without this product.”}
        •	Events – {“Now I feel good.”, “I have succeeded with this product.”,
        “Makes miracles. I am happy of the results!”, “I cannot believe but now I feel awesome.”,
        ”Try it yourself, I am very satisfied.”, “I feel great!”}
        •	Author – {“Diana”, “Petya”, “Stella”, “Elena”, “Katya”, “Iva”, “Annie”, “Eva”}
        •	Cities – {“Burgas”, “Sofia”, “Plovdiv”, “Varna”, “Ruse”}
        The format of the output message is: {phrase} {event} {author} – {city}.
        As an input you take the number of messages to be generated. 
        Print each random message at a separate line.
     * Print the resulting string on the console.
     * https://judge.softuni.bg/Contests/210/Objects-and-Classes-Exercises
     */
    class AdMessage
    {
        static void Main()
        {
            string[] phrases = "Excellent product|Such a great product|I always use that product|Best product of its category"
                .Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
            string[] events = "Now I feel good.|I have succeeded to change.|That makes miracles.|I cannot believe but now I feel awesome.|Try it yourself, I am very satisfied."
                .Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
            string[] authors = "Diana, Petya, Stella, Elena, Katya, Iva, Annie, Misha"
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            string[] cities = "Burgas, Sofia, Plovdiv, Varna, Ruse"
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            Random rnd = new Random();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}. {1} {2} - {3}",
                                phrases[rnd.Next(phrases.Length)],
                                events[rnd.Next(events.Length)],
                                authors[rnd.Next(authors.Length)],
                                cities[rnd.Next(cities.Length)]);
            }
        }
    }
}

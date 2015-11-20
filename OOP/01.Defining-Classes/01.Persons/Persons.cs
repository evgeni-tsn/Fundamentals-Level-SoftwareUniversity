using System;

namespace _01.Persons
{
    class Persons
    {
        static void Main()
        {
            Person pesho = new Person("pesho", 20);
            //Throw Exception for mail

            //Person gosho = new Person("gosho", 200,"mail.bg");

            //Throw Exception for age
            //Person mariika = new Person("mariika", 150,"test@mail.bg");

            Person ivan = new Person("Ivan", 28,"ivan@mail.bg");

            Console.WriteLine(pesho);
            //Console.WriteLine(gosho);
            //Console.WriteLine(mariika);
            Console.WriteLine(ivan);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.SoftwareUniversityLearningSystem
{
    class SULS
    {
        static void Main()
        {
            var persons = new List<Person>()
            {
                new DropoutStudent("Dimitar", "Berbatov", 35, 159, 4.55,"Low scores"),
                new OnsiteStudent("Pesho", "Peshov", 80, 977, 2.01, "C# Basic", 1),
                new OnlineStudent("Ivaylo", "Tokiev", 33, 897, 4.90, "OOP"),
                new GraduateStudent("Ivancho", "Mariikin", 16, 159, 2.55),
                new GraduateStudent("Pesho", "Goshev", 2, 159, 6.00),
                new SeniorTrainer("Svetlin", "Nakov", 50),
                new JuniorTrainer("Koicho", "Koichev", 99),
            };
            var person = new SeniorTrainer("Svetlin", "Nakov", 40);
            Console.WriteLine(person);
            person.CreateCourse("C#");
            person.DeleteCourse("Java");

            persons
                .OfType<DropoutStudent>()
                .OrderByDescending(student => student.AverageGrade)
                .ToList()
                .ForEach(Console.WriteLine);


        }
    }
}

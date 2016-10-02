using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.AverageGrades
{
    /* 
     * Define a class Student, which holds the following information about 
     * students: name, list of grades and average grade (calculated property, read-only). 
     * A single grade will be in range [2…6], e.g. 3.25 or 5.50.
     * Read a list of students and print the students that have average grade ≥ 5.00 
     * ordered by name (ascending), then by average grade (descending). 
     * Print the student name and the calculated average grade.
     * Print the resulting string on the console.
     * https://judge.softuni.bg/Contests/210/Objects-and-Classes-Exercises
     */
    class AverageGrades
    {
        class Student
        {
            public string Name { get; set; }
            public List<double> Grades { get; set; }
            public double AverageGrade => Grades.Sum() / Grades.Count;
        }

        public class Average_Grades
        {
            public static void Main()
            {
                Student[] studentGrades = GetStudentGrades();
                string[] topStudents = studentGrades
                    .Where(x => x.AverageGrade >= 5)
                    .Select(x => x.Name).Distinct()
                    .OrderBy(x => x)
                    .ToArray();

                foreach (string student in topStudents)
                {
                    var studentAverageGrades = studentGrades
                        .Where(x => x.Name == student && x.AverageGrade >= 5)
                        .Select(x => x.AverageGrade)
                        .OrderByDescending(x => x)
                        .ToArray();
                    foreach (double studentAverageGrade in studentAverageGrades)
                        Console.WriteLine("{0} -> {1:f2}", student, studentAverageGrade);
                }
            }

            private static Student[] GetStudentGrades()
            {
                int n = int.Parse(Console.ReadLine());
                Student[] grades = new Student[n];
                for (int i = 0; i < n; i++)
                {
                    List<double> studentGrades = new List<double>();
                    string[] data = Console.ReadLine()
                        .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                    for (int j = 1; j < data.Length; j++)
                        studentGrades.Add(double.Parse(data[j]));
                    grades[i] = new Student {Name = data[0], Grades = studentGrades};
                }
                return grades;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string Name { get; set; }
    public int Grade { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student { Name = "Seema", Grade = 95, Age = 20 },
            new Student { Name = "Sivraam", Grade = 92, Age = 21 },
            new Student { Name = "Ridhinya", Grade = 80, Age = 22 },
            new Student { Name = "Krish", Grade = 65, Age = 19 }
        };

        Console.Write("Enter grade threshold: ");
        int threshold = int.Parse(Console.ReadLine());

        var filteredStudents = students
            .Where(s => s.Grade > threshold)
            .OrderBy(s => s.Name)
            .ToList();

        Console.WriteLine("\nStudents with grade above threshold:");
        foreach (var student in filteredStudents)
        {
            Console.WriteLine($"{student.Name} - Grade: {student.Grade}, Age: {student.Age}");
        }
    }
}
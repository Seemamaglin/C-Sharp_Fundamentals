using System;
using Task_8.Interfaces;
using Task_8.Models;
using Task_8.Repositories;

namespace Task_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IRepository<Student> repo = new InMemoryRepository<Student>();

            repo.Add(new Student { Id = 1, Name = "Seema", Age = 21 });
            repo.Add(new Student { Id = 2, Name = "Ravi", Age = 22 });

            Console.WriteLine("All Students:");
            foreach (var s in repo.GetAll())
            {
                Console.WriteLine($"{s.Id} {s.Name} {s.Age}");
            }

            Console.WriteLine("\nUpdating Student 1");
            repo.Update(new Student { Id = 1, Name = "Seema Maglin", Age = 22 });

            var student = repo.GetById(1);
            Console.WriteLine($"{student.Id} {student.Name} {student.Age}");

            Console.WriteLine("\nDeleting Student 2");
            repo.Delete(2);

            Console.WriteLine("\nFinal List:");
            foreach (var s in repo.GetAll())
            {
                Console.WriteLine($"{s.Id} {s.Name} {s.Age}");
            }
        }
    }
}
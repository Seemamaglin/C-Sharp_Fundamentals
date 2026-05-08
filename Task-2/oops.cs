using System;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void Introduce()
    {
        Console.WriteLine($"Hi, my name is {Name} and I am {Age} years old.");
    }
}

class Program
{
    static void Main()
    {
        Person p1 = new Person();
        p1.Name = "Seema";
        p1.Age = 20;

        Person p2 = new Person();
        p2.Name = "Rahul";
        p2.Age = 22;

        Person p3 = new Person();
        p3.Name = "Anita";
        p3.Age = 25;

        p1.Introduce();
        p2.Introduce();
        p3.Introduce();
    }
}
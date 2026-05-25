using Task_8.Interfaces;

namespace Task_8.Models
{
    public class Student : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
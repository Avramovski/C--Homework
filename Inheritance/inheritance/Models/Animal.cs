
namespace inheritance.Models
{
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public Animal(){ Console.WriteLine("First constructor"); }

        public Animal(string type)
        {
            Type = type;
            Console.WriteLine("Secund constructor");
        }
        public Animal(string name ,string type)
        {
            Name = name;
            Type = type;
            Console.WriteLine("Third constructor");
        }
        public virtual void Eat()
        {
            Console.WriteLine($"The {Type} animal with {Name} is eating");
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Animal {Name} with id:{Id} of type:{Type}");
        }
    }
}

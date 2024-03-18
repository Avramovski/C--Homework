

namespace inheritance.Models
{
    public class Dog : Animal
    {
        public string Race { get; set; }

        public Dog()
        {
            Console.WriteLine("First constructor in Dog");
        }
        public void Bark()
        {
            Console.WriteLine("BArk bark bark");
        }
        public Dog(string name , string type)
        {
            Name = name;
            Type = type;
        }

    }
}



namespace inheritance.Models
{
    public class Cat : Animal
    {
        public string Lazyness { get; set; }

        public Cat() : base("Cat")
        {
        
        }
        public Cat(string name ,string type,string layziness) : 
            base(name,type) 
        {
            Lazyness = layziness;
            Console.WriteLine("With two parametars");
        }
        public override void Eat()
        {
            Console.WriteLine($"You dont tell the cat {Name} when to eat");
        }
        public void Meow()
        {
            Console.WriteLine("Mjaauuuu auuu");
        }
    }
}

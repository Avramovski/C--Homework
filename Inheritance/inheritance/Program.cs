// See https://aka.ms/new-console-template for more information
using inheritance.Models;

Console.WriteLine("Hello, World!");

#region Inheritence
Animal animal = new Animal()
{
    Id = 5,
Name = "Dambo",
Type = "Elephant"
};

animal.Eat();
animal.PrintInfo();

Console.WriteLine("=================================================");

Dog spark = new Dog()
{
    Name = "Spark",
    Id = 1,
    Type = "Dog",
    Race = "Labrador"
};

spark.Eat();
spark.PrintInfo();
spark.Bark();

Dog bark = new Dog("Bak","Dog");
bark.Eat();

Console.WriteLine("===========================================");
Cat garfild = new Cat()
{
    Name = "garfild",
    Lazyness =  "Very",
    Id= 11,
    
};
garfild.Eat();
garfild.PrintInfo();
Cat tom = new Cat("Tom","Cat","vary");
tom.PrintInfo();
tom.Meow();
#endregion
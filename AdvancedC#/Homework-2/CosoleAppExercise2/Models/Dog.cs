﻿
namespace CosoleAppExercise2.Models
{
    public class Dog : Pet
    {
        public bool GoodBoy { get; set; }
        public string FavoriteFood { get; set; }
        public Dog(string name, string type, int age, bool goodBoy, string favoriteFood) : base(name, type, age)
        {
            Name = name;
            Type  = type;
            Age = age;
            GoodBoy = goodBoy;
            FavoriteFood = favoriteFood;
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"{Name} is {Type} [{Age}]-years old");
        }
    }
}

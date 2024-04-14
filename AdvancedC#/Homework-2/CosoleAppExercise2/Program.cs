using CosoleAppExercise2.Models;

PetStore<Dog> dogStore = new PetStore<Dog>();
dogStore.AddPet(new Dog("Buddy","Dog",3,false,"Dogfoood"));
dogStore.AddPet(new Dog("Max", "Dog", 5, true, "Dogfoood"));

PetStore<Cat> catStore = new PetStore<Cat>();
catStore.AddPet(new Cat("Bob", "Cat", 3, true, 10));
catStore.AddPet(new Cat("Bobi", "Cat", 4, true, 8));

PetStore<Fish> petStore = new PetStore<Fish>();

petStore.AddPet(new Fish("Fiki", "Fish", 4, "Blue", "Small"));
petStore.AddPet(new Fish("Fisi", "Fish", 2, "Pink", "Big"));

dogStore.BuyPet("Max");
catStore.BuyPet("Bob");


dogStore.PrintPets();

catStore.PrintPets();

petStore.PrintPets();

namespace CosoleAppExercise2.Models
{
    public class PetStore<T> where T : Pet
    {
         List<T> pets = new();

        public void PrintPets()
        {
            if (pets.Count == 0)
            {
                Console.WriteLine("No pets available in the stoe");
                return;
            }

            Console.WriteLine($"Pets available in the {typeof(T).Name} store:");
            foreach (T pet in pets)
            {
                pet.PrintInfo();
            }
        }
        public void AddPet(T pet)
        {
            pets.Add(pet);
        }
        public void BuyPet(string name)
        {
            bool found = false;
            for (int i = 0; i < pets.Count; i++)
            {
                if (pets[i] is Dog dog && dog.Name == name)
                {
                    pets.RemoveAt(i);
                    Console.WriteLine($"Congratulations! You have successfully bought {name}");
                    found = true;
                    break;
                }
                else if (pets[i] is Cat cat && cat.Name == name)
                {
                    pets.RemoveAt(i);
                    Console.WriteLine($"Congratulations! You have successfully bought {name}");
                    found = true;
                    break;
                }
                else if (pets[i] is Fish fish && fish.Name == name)
                {
                    pets.RemoveAt(i);
                    Console.WriteLine($"Congratulations! You have successfully bought {name}");
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine($"Sorry, there is no pet named {name} available in the store");
            }

        }
    }
}

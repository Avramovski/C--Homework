
using ConsoleAppTask01.Models.Interfaces;

namespace ConsoleAppTask01.Models
{
    public abstract class User :IUser
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public int Id { get; set; }

        public virtual void PrintUser()
        {
            Console.WriteLine($"{Name} with Username: {Username} and Id: {Id}");
        }
    }
}


using ClassLibrary.Domain;
using ClassLibrary.Helpers;
using ClassLibrary.Services.Enums;
using ClassLibrary.Services.Interfaces;

namespace ClassLibrary.Services.Models
{
    public class UIService : IUIServices
    {
        public List<MenuChoice> MenuItems { get; set; }

        public int ChooseMenu<T>(List<T> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {items[i]}");
            }
            int choice = ValidationHelper.ValidateNumberInput(Console.ReadLine(), items.Count);
            return choice;
        }

        public User LoginMenu()
        {
            
                Console.Clear();
                ExtendedConsole.PrintInColor("\nEnter your credentials:", ConsoleColor.Cyan);
                string username = ExtendedConsole.GetInput("Username: ");
                string password = ExtendedConsole.GetInput("Password: ");
                if (!ValidationHelper.ValidateStringInput(username) || !ValidationHelper.ValidateStringInput(password))
                {
                    throw new Exception("Please enter valid inputs!");
                }
                return new User()
                {
                    Username = username,
                    Password = password
                };                             
        }

        
        public User RegisterMenu()
        {
            ExtendedConsole.PrintTitle("Register");
            string firstName = ExtendedConsole.GetInput("Enter your first name:");
            string lastName = ExtendedConsole.GetInput("Enter your last name:");
            string username = ExtendedConsole.GetInput("Choose a username:");
            string password = ExtendedConsole.GetInput("Choose a password:");
            User newUser = new User(firstName, lastName, username, password);
            return newUser;
        }
        public void EndMenu()
            {
                Console.Clear();
                ExtendedConsole.PrintTitle("\n\n              *** THANK YOU FOR USING OUR APP ***");
                Console.ReadLine();
            }
    }
}


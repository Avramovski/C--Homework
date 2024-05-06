
using ClassLibrary.Domain;
using ClassLibrary.Helpers;
using ClassLibrary.Services.Interfaces;
using System.Data;

namespace ClassLibrary.Services.Models
{
    public class UserService : ServiceBase<User>, IUserService
    {
        public User CurrentUser { get; set; }

        public void Lgout()
        {
            CurrentUser = null;
        }

        public void Login(string username, string password)
        {
            
                ValidationHelper.ValidatieUsername(username);
            ValidationHelper.ValidatiePassword(password);
            User userDb = GetAll().SingleOrDefault(u => u.Username.Equals(username, StringComparison.InvariantCultureIgnoreCase) && u.Password == password);
            if (userDb is null)
            {
                throw new Exception("Login failed! Invalid credentials entered! Try again...");
            }
            CurrentUser = userDb;
           
        }


        public void Register(string username, string password)
        {
          
            bool userExists = GetAll().Any(x => x.Username.Equals(username, StringComparison.OrdinalIgnoreCase));
            if (userExists)
            {
                throw new Exception("User already exists!");
            }
            if (!ValidationHelper.ValidatieUsername(username))
            {
                throw new Exception("Invalid username format!");
            }

           
            if (!ValidationHelper.ValidatiePassword(password))
            {
                throw new Exception("Invalid password format!");
            }
            User newUser = new User(username, password);
            
            Insert(newUser);
        }
    }
}

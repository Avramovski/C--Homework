using ClassLibrary.Domain.Activitys;

namespace ClassLibrary.Domain.DomainModels
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public List<Reading> Reading { get; set; } = new List<Reading> { };
        public List<Exercising> Exercising { get; set; } = new List<Exercising>();
        public List<Working> Working { get; set; } = new List<Working>();
        public List<OtherHobbies> Hobbies { get; set; } = new List<OtherHobbies>();
        public override string GetInfo()
        {
            return $"{FirstName} with Username: {Username} and {Id}) Id";
        }
        public User()
        {

        }
        public User(string firstName, string lastName, string username, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Username = username;
            Password = password;
        }
        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

// Define a class to represent a user
class User
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public bool IsDeactivated { get; set; }
    // Additional properties and methods as needed
}

// Define a class to manage user authentication and account management
class AuthenticationManager
{
    private List<User> users = new List<User>();

    // Method to register a new user
    public void Register(string firstName, string lastName, int age, string username, string password)
    {
        // Validate inputs
        // Add additional validations as needed
        if (string.IsNullOrEmpty(username) || username.Length < 5)
        {
            Console.WriteLine("Error: Username should be at least 5 characters long.");
            return;
        }

        if (string.IsNullOrEmpty(password) || password.Length < 6)
        {
            Console.WriteLine("Error: Password should be at least 6 characters long.");
            return;
        }

        // Check if username already exists
        if (users.Any(u => u.Username == username))
        {
            Console.WriteLine("Error: Username already exists.");
            return;
        }

        // Create and add new user
        var newUser = new User
        {
            FirstName = firstName,
            LastName = lastName,
            Age = age,
            Username = username,
            Password = password
        };
        users.Add(newUser);

        Console.WriteLine("Success: User registered.");
    }

    // Method to login
    public User Login(string username, string password)
    {
        var user = users.FirstOrDefault(u => u.Username == username && u.Password == password);
        if (user == null)
        {
            Console.WriteLine("Error: Invalid username or password.");
            return null;
        }

        if (user.IsDeactivated)
        {
            Console.WriteLine("Error: Account deactivated.");
            return null;
        }

        Console.WriteLine("Success: Logged in.");
        return user;
    }

    // Method to change password
    public void ChangePassword(User user, string newPassword)
    {
        user.Password = newPassword;
        Console.WriteLine("Success: Password changed.");
    }

    // Method to deactivate account
    public void DeactivateAccount(User user)
    {
        user.IsDeactivated = true;
        Console.WriteLine("Success: Account deactivated.");
    }

    // Method to reactivate account
    public void ReactivateAccount(User user)
    {
        user.IsDeactivated = false;
        Console.WriteLine("Success: Account reactivated.");
    }

    // Additional methods for account management
}

// Main class to run the application
class Program
{
    static void Main(string[] args)
    {
        AuthenticationManager authManager = new AuthenticationManager();

        // Example usage
        authManager.Register("John", "Doe", 30, "johndoe", "password");
        var user = authManager.Login("johndoe", "password");

        if (user != null)
        {
            authManager.ChangePassword(user, "newpassword");
            authManager.DeactivateAccount(user);
            authManager.Login("johndoe", "password"); // This should fail due to account deactivation
            authManager.ReactivateAccount(user);
            authManager.Login("johndoe", "newpassword"); // This should succeed after reactivation
        }
    }
}

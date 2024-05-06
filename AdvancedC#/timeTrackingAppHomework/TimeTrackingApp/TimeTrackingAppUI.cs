
using ClassLibrary.Domain;
using ClassLibrary.Helpers;
using ClassLibrary.Services.Interfaces;
using ClassLibrary.Services.Models;

namespace TimeTrackingApp
{
    public class TimeTrackingAppUI
    {
        private readonly IUIServices _uiServices;
        private readonly IUserService _userService;

        public TimeTrackingAppUI()
        {
            _uiServices = new UIService();
            _userService = new UserService();
            FixedUsers();
        }
        public void App()
        {
            while (true)
            {
                if (_userService.CurrentUser == null)
                {
                    DisplayLoginRegisterOptions();
                }
                else
                {
                    DisplayLogoutOption();
                }

            }
        }
        private void DisplayLoginRegisterOptions()
        {
            try
            {
                ExtendedConsole.PrintTitle("\n\t*** Time Tracking app ***\n");
                int choice = _uiServices.ChooseMenu(new List<string> { "Login", "Register", "End" });
                if (choice == -1)
                {
                    ExtendedConsole.PrintError("Invalid choice! Try again...");
                    return;
                }
                if (choice == 1)
                {
                    User inputUser = _uiServices.LoginMenu();
                    _userService.Login(inputUser.Username, inputUser.Password);
                    ExtendedConsole.PrintSuccess($"\nWelcome {_userService.CurrentUser.FirstName} {_userService.CurrentUser.Username} !");
                }
                else if (choice == 2)
                {
                    User newUser = _uiServices.RegisterMenu();
                    _userService.Register(newUser.Username, newUser.Password);
                    ExtendedConsole.PrintSuccess("Registration successful!");
                }
                else if (choice == 3)
                {
                    _uiServices.EndMenu();
                    _userService.Lgout();
                }
            }
            catch (Exception ex)
            {
                ExtendedConsole.PrintError(ex.Message);
            }
        }
        private void DisplayLogoutOption()
        {
            try
            {
                ExtendedConsole.PrintTitle("\n\t*** Time Tracking app ***\n");
                int choice = _uiServices.ChooseMenu(new List<string> { "Logout", "Back to Main Menu" });
                _userService.Lgout();
                if (choice == -1)
                {
                    ExtendedConsole.PrintError("Invalid choice! Try again...");
                    return;
                }

                if (choice == 1)
                {
                    _userService.Lgout();
                    ExtendedConsole.PrintSuccess("Logout successful!");
                    _uiServices.ChooseMenu(new List<string> { "Login", "Register" });

                }
                else if (choice == 2)
                {
                    _uiServices.ChooseMenu(new List<string> { "Login", "Register" });
                }
            }
            catch (Exception ex)
            {
                ExtendedConsole.PrintError(ex.Message);
            }
        }
        private void FixedUsers()
        {
          
            User user1 = new User("Nikola", "Avramovski", "Nikola", "Nikola123");
            List<User> users = new List<User>() { user1 };

            _userService.Seed(users);
        }
    }
}


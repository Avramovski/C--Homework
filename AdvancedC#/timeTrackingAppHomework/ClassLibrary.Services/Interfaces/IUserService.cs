using ClassLibrary.Domain.DomainModels;
using System.Data;

namespace ClassLibrary.Services.Interfaces
{
    public interface IUserService : IServiceBase<User>
    {
        User CurrentUser { get; set; }
        void Login(string username, string password);
        void Register(string firstName, string lastName, string username, string password);
        void Lgout();

        bool ChangePassword(string oldPassword, string newPassword);


    }
}

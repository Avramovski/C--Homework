

using ClassLibrary.Domain;
using System.Data;

namespace ClassLibrary.Services.Interfaces
{
    public interface IUserService : IServiceBase<User>
    {
        User CurrentUser { get; set; }
        void Login(string username, string password);
        void Register(string username, string password);
        void Lgout();
       
    }
}

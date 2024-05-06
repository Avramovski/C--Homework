
using ClassLibrary.Domain;
using ClassLibrary.Services.Enums;

namespace ClassLibrary.Services.Interfaces
{
    public interface IUIServices
    {
        List<MenuChoice> MenuItems { get; set; }
        User LoginMenu();
        int ChooseMenu<T>(List<T> items);
        User RegisterMenu();
        void EndMenu();
    }
}

using ClassLibrary.Services.Enums;

namespace ClassLibrary.Domain.Activitys
{
    public class OtherHobbies : ActivityBase
    {
        public double TimeSpentOnActivity { get; set; }

        public HobbiesE Type { get; set; }

        public OtherHobbies(HobbiesE hobbiesE)
        {
            Type = hobbiesE;
        }
    }
}

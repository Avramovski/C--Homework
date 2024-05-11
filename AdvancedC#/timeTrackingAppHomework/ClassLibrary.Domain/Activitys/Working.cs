using ClassLibrary.Services.Enums;

namespace ClassLibrary.Domain.Activitys
{
    public class Working : ActivityBase
    {
        public WorkingE Type { get; set; }
        public double TimeSpentOnActivity { get; set; }

        public Working(WorkingE workingRole)
        {
            Type = workingRole;
        }
    }
}

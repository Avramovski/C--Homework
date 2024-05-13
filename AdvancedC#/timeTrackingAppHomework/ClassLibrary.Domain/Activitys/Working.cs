using ClassLibrary.Services.Enums;

namespace ClassLibrary.Domain.Activitys
    {
        public class Working : ActivityBase
        {
            public WorkingE Type { get; set; }
            public TimeSpan TimeSpentOnActivity { get; set; }
     
            public Working (WorkingE workingE)
            {
                Type = workingE;
            }
        }
    }

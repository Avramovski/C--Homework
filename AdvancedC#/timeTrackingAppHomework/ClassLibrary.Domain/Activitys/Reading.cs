using ClassLibrary.Services.Enums;

namespace ClassLibrary.Domain.Activitys
{
    public class Reading : ActivityBase
    {
        public TimeSpan TimeSpentOnActivity { get; set; }
        public int Pages { get; set; }
        public ReadingE Type { get; set; }
        public Reading(ReadingE readingE,int pages)
        {
            Type = readingE;  
            Pages = pages;
        }
    }
}

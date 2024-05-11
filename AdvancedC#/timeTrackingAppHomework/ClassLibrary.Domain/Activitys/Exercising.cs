using ClassLibrary.Services.Enums;

namespace ClassLibrary.Domain.Activitys
{
    public class Exercising : ActivityBase
    {
        public TimeSpan TimeSpentOnActivity { get; set; }
       public ExercisingE Type { get; set; }

        public Exercising(ExercisingE exercisingE)
        {
            Type = exercisingE;
        }
    }
}

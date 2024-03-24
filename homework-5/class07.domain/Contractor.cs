

namespace class07.domain
{
    public class Contractor : Employee
    {
        public double WorkHours { get; set; }
        public int PayPerHour { get; set; }
        public Manager Responsible { get; set; }
        public Contractor()
        {
            
        }
        public Contractor(double workHours,int payPerHour)
        {
            WorkHours = workHours;
            PayPerHour = payPerHour;
           

        }
        public override double GetSalary()
        {
            Salary = WorkHours * PayPerHour;
            return Salary;
        }
    }
}

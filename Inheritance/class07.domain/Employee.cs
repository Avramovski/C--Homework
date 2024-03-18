
using class07.domain.Enums;

namespace class07.domain
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role {  get; set; }
        protected double Salary {  get; set; }

        
        public void PrintInfo()
        {
            Console.WriteLine($"First name:{FirstName} ,Last name:{LastName} ,Salart:{GetSalary()}");
        }
        public virtual double GetSalary()
        {
            return Salary;
        }

       
    }
}



namespace class07.domain
{
    public class Ceo : Employee
    {
        public Employee[] Employees { get; set; }
        public int Shares { get; set; }
        private double SharesPrice { get; set; }

        public Ceo()
        {
            
        }
        public Ceo(Employee[] employees,int shares ,string firstName,string lastName )
        {
            Employees = employees;
            Shares = shares;
            SharesPrice = 20.50;
            FirstName = firstName;
            LastName = lastName;

            
        }
        public double AddSharesPrice(double num)
        {
          double  res = 20.50 +  num;
            return res;
        }
        public void PrintEmployees()
        {
            foreach (Employee emp in Employees)
            {
                Console.WriteLine($"{emp.FirstName}  {emp.LastName}");
            }
        }
        public override double GetSalary()
        {
            return Salary + (Shares *  SharesPrice);
        }
    }
    
}

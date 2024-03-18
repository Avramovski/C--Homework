using class07.domain.Enums;


namespace class07.domain
{
    public class SalesPerson : Employee
    {
        public SalesPerson(string firstName ,string lastName, int salery)
        {
            FirstName = firstName;
             LastName = lastName;
            Role = Role.Sales;
            Salary = salery;

        }
   
    }
}

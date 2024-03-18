using class07.domain;
using class07.domain.Enums;

Employee employee = new Employee()
{
    FirstName = "Zlatko",
    LastName ="Zlatev",
    Role = Role.Other
};

Employee employee1ForHomework = new Employee()
{
    FirstName = "Nikola",
    LastName ="Avramovski",
    Role = Role.Other
};
Employee employee2ForHomework = new Employee()
{
    FirstName = "Petko",
    LastName ="Petkovski",
    Role = Role.Other
};

Contractor contractor1 = new Contractor()
{
    FirstName = "Trajko",
    LastName = "Mirceski",
    Role = Role.Contractor,
    WorkHours = 28.00,
    PayPerHour = 10
};

Contractor contractor2 = new Contractor()
{
    FirstName = "Petko",
    LastName = "Stankoski",
    Role = Role.Contractor,
    WorkHours = 35.00,
    PayPerHour = 10
};
Manager manager1 = new Manager("Filip","Makedonski",550.00);
Manager manager2 = new Manager("Pco", "Petrevski", 700.00);

SalesPerson salesPerson1 = new SalesPerson("Sime", "Simonoski", 600);

Employee[] Company =
{
    contractor1,
    contractor2,
    manager1,
    manager2,
    salesPerson1,

};

Ceo ceo = new Ceo(Company,100,"Ceo","Glavniot");

ceo.PrintInfo();
Console.WriteLine("Ceo salary is: "  + ceo.GetSalary());
Console.WriteLine("Employees:");
ceo.PrintEmployees();
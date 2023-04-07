

using Employees;
using System.Diagnostics.Contracts;

static void Main(string[] args)
{
    Employee employee1 = new Employee()
    {
        FirstName = "Ed",
        LastName = "Sheeran",
        Role = RoleEnum.Manager
    };
    Console.WriteLine(employee1.GetInfo());

    int enumToInt = (int)employee1.Role;
    Console.WriteLine(enumToInt);

    SalesPerson salesPerson = new SalesPerson("Zara", "Larsson");
    salesPerson.AddSuccessRevenue(400);
    Console.WriteLine(salesPerson.GetSalary());

    Manager manager1 = new Manager("Tom", "Cruise", 1200);
    Console.WriteLine(manager1.GetSalary());
    manager1.AddBonus(250);
    Console.WriteLine(manager1.GetSalary());

    Employee employee2 = new Employee()
    {
        FirstName = "Emma",
        LastName = "Watson",
        Role = RoleEnum.Developer
    };
    Console.WriteLine(employee2.GetInfo());

    Employee employee3 = new Employee()
    {
        FirstName = "Daniel",
        LastName = "Radcliffe",
        Role = RoleEnum.Marketing
    };
    Console.WriteLine(employee3.GetInfo());

    Contractor contractor = new Contractor()
    {
        FirstName = "John",
        LastName = "Doe",
        Role = RoleEnum.Contractor,
        WorkHours = 8,
        PayPerHour = 20,
        Responsible = manager1
    };
    Console.WriteLine(contractor.CurrentPosition());
    Console.WriteLine(contractor.GetSalary());
    Console.WriteLine(contractor.Salary);
}

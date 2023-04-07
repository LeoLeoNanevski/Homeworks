

using System.Diagnostics.Contracts;
using System.Runtime.ConstrainedExecution;


static void Main(string[] args)
{
    Employee[] company = new Employee[] {
                new Contractor("Bob", "Bobert", 100),
                new Contractor("Rick", "Rickert", 120),
                new Manager("Mona", "Monalisa", 500),
                new Manager("Igor", "Igorsky", 600),
                new SalesPerson("Lea", "Leova", 300)
            };

    CEO ceoName = new CEO("Ron", "Ronsky", 1500, company);
    ceoName.AddSharesPrice(3.4);
    ceoName.PrintInfo();
    ceoName.PrintEmployees();
    Console.WriteLine("Salary of CEO is: " + ceoName.GetSalary());
}
    

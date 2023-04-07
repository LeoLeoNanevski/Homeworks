

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
}

class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double Salary { get; set; }

    public Employee(string firstName, string lastName, double salary)
    {
        FirstName = firstName;
        LastName = lastName;
        Salary = salary;
    }

    public virtual double GetSalary()
    {
        return Salary;
    }
}

class Contractor : Employee
{
    public Contractor(string firstName, string lastName, double salary) : base(firstName, lastName, salary)
    {
    }
}

class Manager : Employee
{
    public Manager(string firstName, string lastName, double salary) : base(firstName, lastName, salary)
    {
    }
}

class SalesPerson : Employee
{
    public SalesPerson(string firstName, string lastName, double salary) : base(firstName, lastName, salary)
    {
    }
}

class CEO : Employee
{
    private double sharesPrice;
    public Employee[] Employees { get; set; }
    public int Shares { get; set; }

    public CEO(string firstName, string lastName, double salary, Employee[] employees) : base(firstName, lastName, salary)
    {
        Employees = employees;
    }

    public void AddSharesPrice(double price)
    {
        sharesPrice = price;
    }

    public void PrintEmployees()
    {
        Console.WriteLine("Employees:");
        foreach (Employee e in Employees)
        {
            Console.WriteLine(e.FirstName + " " + e.LastName);
        }
    }

    public override double GetSalary()
    {
        return base.GetSalary() + Shares * sharesPrice;
    }

    public void PrintInfo()
    {
        Console.WriteLine("CEO:");
        Console.WriteLine("First Name: " + FirstName + ", Last Name: " + LastName + ", Salary: " + Salary);
    }
}
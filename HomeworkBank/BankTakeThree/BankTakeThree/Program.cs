

using BankTakeThree.enums;
using BankTakeThree;

Person p = new Person();
p.FirstName = "Alice";
p.LastName = "Smith";
p.Occupation = Occupation.Employee;
p.Education = Education.Bachelor;
p.MonthlyWage = 20000;
p.Address = "123 Main Street";
p.City = "New York";
p.State = "NY";
p.Phone = "212-555-1234";
p.Mobile = "007-555-4321";
p.Email = "alice.smith@gmail.com";
p.BankProducts = new List<BankProduct>() { BankProduct.Deposit, BankProduct.Cards };

// Print some properties and methods of the Person object
Console.WriteLine("First name: " + p.FirstName);
Console.WriteLine("Last name: " + p.LastName);
Console.WriteLine("Occupation: " + p.Occupation);
Console.WriteLine("Education: " + p.Education);
Console.WriteLine("Monthly wage: " + p.MonthlyWage);
Console.WriteLine("Address: " + p.Address);
Console.WriteLine("City: " + p.City);
Console.WriteLine("State: " + p.State);
Console.WriteLine("Phone: " + p.Phone);
Console.WriteLine("Mobile: " + p.Mobile);
Console.WriteLine("Email: " + p.Email);
Console.WriteLine("Bank products: ");
foreach (BankProduct bp in p.BankProducts)
{
    Console.WriteLine(bp);
}

// Create another Person object with some properties
Person q = new Person();
q.FirstName = "Bob";
q.LastName = "Jones";
q.Occupation = Occupation.SelfEmployed;
q.Education = Education.Master;
q.MonthlyWage = 25000;
q.Address = "456 Main Street";
q.City = "New York";
q.State = "NY";
q.Phone = "212-555-5678";
q.Mobile = "007-555-8765";
q.Email = "bob.jones@gmail.com";
q.BankProducts = new List<BankProduct>() { BankProduct.Credit, BankProduct.Deposit, BankProduct.Safe };

// Print some properties and methods of the Person object
Console.WriteLine("First name: " + q.FirstName);
Console.WriteLine("Last name: " + q.LastName);
Console.WriteLine("Occupation: " + q.Occupation);
Console.WriteLine("Education: " + q.Education);
Console.WriteLine("Monthly wage: " + q.MonthlyWage);
Console.WriteLine("Address: " + q.Address);
Console.WriteLine("City: " + q.City);
Console.WriteLine("State: " + q.State);
Console.WriteLine("Phone: " + q.Phone);
Console.WriteLine("Mobile: " + q.Mobile);
Console.WriteLine("Email: " + q.Email);
Console.WriteLine("Bank products: ");
foreach (BankProduct bp in q.BankProducts)
{
    Console.WriteLine(bp);
}

// Check if the Person is a good candidate for credit
Console.WriteLine("Is loan candidate: " + q.IsLoanCandidate());


using BankTakeTwo.enums;
using BankTakeTwo;

List<Client> clients = new List<Client>();

// Create a new Person and add it to the list of clients
Person person = new Person
{
    Address = "123 Main St",
    City = "Springfield",
    State = "IL",
    Phone = "555-1234",
    Mobile = "007-555-1234",
    Email = "johndoe@example.com",
    FirstName = "John",
    LastName = "Doe",
    Occupation = Occupation.Employed,
    Education = Education.Bachelor,
    Age = 30,
    BankProducts = new List<BankProduct> { BankProduct.Credit, BankProduct.Deposit }
};
clients.Add(person);

// Check if the email is valid
Console.WriteLine(person.IsValidEmail()); // True

// Check if the mobile is valid
Console.WriteLine(person.IsValidMobile()); // True

// Check the age of the person
person.CheckAge();

// Check if the person is a loan candidate
Console.WriteLine(person.IsLoanCandidate()); // True

// Create a new LegalEntity and add it to the list of clients
LegalEntity legalEntity = new LegalEntity
{
    Address = "456 Elm St",
    City = "Shelbyville",
    State = "IL",
    Phone = "555-5678",
    Mobile = "007-555-5678",
    Email = "acme@example.com",
    Name = "Acme Inc.",
    ActivityOfTheCompany = CompanyActivity.Manufacturing,
    NumberOfTheEmployee = 100,
    Owners = new List<Person> { person }
};
clients.Add(legalEntity);

// Check if the owners are bank clients
legalEntity.CheckOwners(clients);
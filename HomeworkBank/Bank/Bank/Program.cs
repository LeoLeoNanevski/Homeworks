

using Bank.enums;
using Bank;

var person = new Person
{
    FirstName = "John",
    LastName = "Doe",
    SSN = "12345678901",
    Occupation = Occupation.Employee,
    Education = Education.HighSchool,
    MonthlyWage = 2500,
    Address = "123 Main St",
    City = "Anytown",
    State = "CA",
    Phone = "555-1234",
    Mobile = "007-555-4321",
    Email = "johndoe@example.com",
    BankProducts = new List<BankProduct> { BankProduct.Credit, BankProduct.Deposit }
};

var legalEntity = new LegalEntity
{
    Name = "Acme Corporation",
    TaxNumber = "1234567890",
    ActivityOfTheCompany = ActivityOfTheCompany.Manufacturing,
    NumberOfEmployees = 100,
    Owners = new List<string> { "John Doe", "Jane Smith" },
    Profit = 1000000,
    Address = "456 Oak St",
    City = "Anytown",
    State = "CA",
    Phone = "555-5678",
    Mobile = "007-555-8765",
    Email = "acme@example.com"
};

Console.WriteLine($"Person email is valid: {person.IsValidEmail()}"); // true
Console.WriteLine($"Person has 007 mobile: {person.Has007Mobile()}"); // true
//Console.WriteLine($"Person age is {person.GetAge(new DateTime(1980, 1, 1))}"); // 43
//Console.WriteLine($"Person occupation is {person.GetOccupation(new DateTime(1980, 1, 1))}"); // Employee
//Console.WriteLine($"Person is loan candidate: {person.IsLoanCandidate(new DateTime(1980, 1, 1))}"); // true
Console.WriteLine($"Legal entity tax number is valid: {legalEntity.TaxNumber.Length == 10}"); // true
//Console.WriteLine($"Legal entity owner is already client: {legalEntity.IsOwnerBankClient()}"); // false

var person2 = new Person
{
    FirstName = "John",
    LastName = "Doe",
    SSN = "12345678901",
    Occupation = Occupation.Employee,
    Education = Education.HighSchool,
    MonthlyWage = 2500,
    BankProducts = new List<BankProduct> { BankProduct.Deposit },
    Birthdate = new DateTime(1980, 1, 1)
};

Console.WriteLine($"Is {person2.FirstName} a loan candidate? {person2.LoanCandidates()}");
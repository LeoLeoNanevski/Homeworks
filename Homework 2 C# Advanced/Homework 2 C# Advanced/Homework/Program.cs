
using Homework.Entities;




var fordMondeo = new Car { Id = 4, Type = "Sedan", YearOfProduction = 2022, BatchNumber = "E159", FuelTank = 40, CountriesProducedIn = new List<string> { "Japan" } };
var sanos = new Vehicle { Id = 0, Type = "", YearOfProduction = 2021, BatchNumber = "F753", };
Console.WriteLine($"Is car valid? {Validator.Validate(fordMondeo)}");
Console.WriteLine($"Is vehicle valid? {Validator.Validate(sanos)}");

foreach (var vehicle in DB.Vehicles)
{
    vehicle.PrintVehicle();
}


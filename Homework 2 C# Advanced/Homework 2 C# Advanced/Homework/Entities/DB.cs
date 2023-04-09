using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Entities
{
    public static class DB
    {
        public static List<Vehicle> Vehicles = new List<Vehicle>
        {
            new Car {Id = 1, Type = "SUV", YearOfProduction = 2021, BatchNumber = "B123", FuelTank = 50, CountriesProducedIn = new List<string>{ "Germany", "Great Britain"} },
            new Bike{Id = 2, Type = "Downhill", YearOfProduction = 2023, BatchNumber = "C456", Color = "Black" },
            new Vehicle {Id = 3, Type = "Cisterna", YearOfProduction = 1988, BatchNumber = "D789" }
        };
    }
}

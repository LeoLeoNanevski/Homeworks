using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Entities
{
    public class Bike : Vehicle
    {
        public string Color { get; set; }
        public override void PrintVehicle()
        {
            Console.WriteLine($"Bike year of Production: {YearOfProduction}, Color: {Color}");
        }
    }
}

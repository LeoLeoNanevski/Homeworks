using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Entities
{
    public class Car : Vehicle
    {
        public int FuelTank { get; set; }
        public List<string> CountriesProducedIn { get; set; }
        public override void PrintVehicle()
        {
            Console.WriteLine($"Car type:{Type}, Countries produced in: {string.Join(",", CountriesProducedIn)}");
        }
    }
}

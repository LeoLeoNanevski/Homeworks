using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Entities
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int YearOfProduction { get; set; }
        public string BatchNumber { get; set; }

        public virtual void PrintVehicle()
        {
            Console.WriteLine($"Vehicle Id: {Id}, Type: {Type}, Year of production: {YearOfProduction}");
        }
    }
  
}

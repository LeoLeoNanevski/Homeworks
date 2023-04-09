using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Entities
{
    public static class Validator
    {
        public static bool Validate(Vehicle vehicle)
        {
            if (vehicle.Id ==0 || string.IsNullOrEmpty(vehicle.Type) || vehicle.YearOfProduction == 0)
            {
                return false;
            }
            return true;
        }
    }
}

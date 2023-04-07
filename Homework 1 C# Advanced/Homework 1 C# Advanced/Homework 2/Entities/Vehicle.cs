using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2.Entities
{
    public abstract class Vehicle
    {
        public bool IsBroken { get; set; } = false;

        public abstract void Drive();
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Dealership_App.Entities
{
    public class FrenchCar : BaseEntity
    {
        public override void Drive(string destinationName)
        {
            Console.WriteLine($"Driving French car {Brand} {Model} to {destinationName}...");
        }
    }
}

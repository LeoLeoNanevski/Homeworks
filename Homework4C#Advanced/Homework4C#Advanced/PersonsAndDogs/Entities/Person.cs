﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsAndDogs.Entities
{
    public class Person
    {
        public string FirstName { get; set; }
        public int Age { get; set; }
        public List<Dog> Dogs { get; set; }
    }
}

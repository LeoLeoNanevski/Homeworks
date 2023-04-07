using Homework_1.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Homework_1.Entities
{
    public abstract class Animal : IAnimal
    {
        public int Age { get; set; }
        public string Kind { get; set; }
        public bool IsFlying { get; set; }

        public Animal(int age, string kind, bool isflying)
        {
            Age = age;
            Kind = kind;
            IsFlying = isflying;
        }

        public abstract void PrintAnimal();
    }
}

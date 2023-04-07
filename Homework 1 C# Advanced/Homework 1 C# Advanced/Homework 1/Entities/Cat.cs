using Homework_1.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1.Entities
{
    public class Cat : Animal, ICat
    {
        public Cat(int age, string kind, bool isflying) : base(age, kind, isflying)
        {
        }
        public override void PrintAnimal()
        {
            Console.WriteLine($"{Age} years old {Kind} {(IsFlying ? "that can fly" : "that can't fly")}");
        }

        public void Eat()
        {
            Console.WriteLine("Nnjam, Njam");
        }
        public void Eat(string food)
        {
            Console.WriteLine($"The {Kind} is eating {food}");
        }


    }
}

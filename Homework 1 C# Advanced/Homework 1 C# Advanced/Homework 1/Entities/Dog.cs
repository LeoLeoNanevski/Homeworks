using Homework_1.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1.Entities
{
    public class Dog : Animal, IDog 
    {
        public Dog(int age, string kind, bool isflying) : base(age, kind, isflying) 
        { 
        }
        public override void PrintAnimal()
        {
            Console.WriteLine($"{Age} years old {Kind} {(IsFlying ? "that can fly" : "that can't fly")}");
        }

        public void Bark()
        {
            Console.WriteLine("Woof! Woof!");
        }
    }
}

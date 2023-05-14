using PersonsAndDogs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsAndDogs.DB
{
    public static class Database
    {
        public static List<Person> Persons { get; set; }
        public static List<Dog> Dogs { get; set; }

        static Database()
        {
            Persons = new List<Person>
        {
            new Person
            {
                FirstName = "Cristofer",
                Age = 35,
                Dogs = new List<Dog>
                {
                    new Dog { Name = "Buddy", Age = 2, Color = "White" },
                    new Dog { Name = "Max", Age = 5, Color = "Brown" }
                }
            },
            new Person
            {
                FirstName = "Freddy",
                Age = 25,
                Dogs = new List<Dog>
                {
                    new Dog { Name = "Charlie", Age = 1, Color = "Black" },
                    new Dog { Name = "Rocky", Age = 3, Color = "Brown" },
                    new Dog { Name = "Bella", Age = 4, Color = "White" }
                }
            },
            new Person
            {
                FirstName = "Erin",
                Age = 30,
                Dogs = new List<Dog>
                {
                    new Dog { Name = "Lola", Age = 2, Color = "White" },
                    new Dog { Name = "Cooper", Age = 7, Color = "Black" }
                }
            },
            new Person
            {
                FirstName = "Nathen",
                Age = 40,
                Dogs = new List<Dog>
                {
                    new Dog { Name = "Duke", Age = 6, Color = "Brown" },
                    new Dog { Name = "Lucy", Age = 8, Color = "White" }
                }
            },
            new Person
            {
                FirstName = "Robert",
                Age = 50,
                Dogs = new List<Dog>
                {
                    new Dog { Name = "Rex", Age = 3, Color = "Brown" }
                }
            },
            new Person
            {
                FirstName = "Richard",
                Age = 45,
                Dogs = new List<Dog>
                {
                    new Dog { Name = "Sam", Age = 2, Color = "Black" },
                    new Dog { Name = "Daisy", Age = 4, Color = "Brown" },
                    new Dog { Name = "Molly", Age = 7, Color = "White" }
                }
            }
        };

            Dogs = Persons.SelectMany(p => p.Dogs).ToList();
        }
    }
}

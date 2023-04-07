

using Homework_1.Entities;


Dog dogOne = new Dog(5, "Jazovicar", false);
dogOne.PrintAnimal();
dogOne.Bark();

Dog dogTwo = new Dog(12, "Cane Corso", false);
dogTwo.PrintAnimal();
dogTwo.Bark();

Cat catOne = new Cat(7, "Street Cat", true);
catOne.PrintAnimal();
catOne.Eat();
catOne.Eat("container leftovers");

Cat catTwo = new Cat(18, "Persian", false);
catTwo.Eat();
catTwo.Eat("beluga");


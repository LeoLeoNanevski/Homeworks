
using Car_Dealership_App.Entities;

var listaNaVozila = new GenericDb<BaseEntity>();
var car1 = new JapaneseCar { Id = 1, Brand = "Toyota", Model = "Corolla", MaxSpeed = 180, HorsePower = 140, FuelType = "Gasoline" };
var car2 = new GermanCar { Id = 2, Brand = "Volkswagen", Model = "Golf", MaxSpeed = 220, HorsePower = 200, FuelType = "Diesel" };
var car3 = new FrenchCar { Id = 3, Brand = "Peugeot", Model = "208", MaxSpeed = 190, HorsePower = 130, FuelType = "Diesel" };
var car4 = new AmericanCar { Id = 4, Brand ="Ford", Model = "Kuga", MaxSpeed = 208, HorsePower= 200, FuelType = "Gasoline" };

listaNaVozila.Insert(car1);
listaNaVozila.Insert(car2);
listaNaVozila.Insert(car3);
listaNaVozila.Insert(car4);


Console.WriteLine("Vozila:");
listaNaVozila.PrintAll();


Console.WriteLine();

Console.WriteLine("Menuvanje na boja na tekst vo konzola:");
Console.WriteLine("Jas sum oboen tekst i od tuka nadolu ke bide tekstot vo boja".ToColor(ConsoleColor.Cyan));

Console.WriteLine();

var vtoroVozilo = listaNaVozila.GetById(2);
Console.WriteLine($"{vtoroVozilo.Brand} {vtoroVozilo.Model} ({vtoroVozilo.Id})");
Console.WriteLine();
Console.WriteLine("Driving:");
vtoroVozilo.Drive("work");
Console.WriteLine();

var prvoVozilo = listaNaVozila.GetById(1);
Console.WriteLine($"{prvoVozilo.Brand} {prvoVozilo.Model} ({prvoVozilo.Id})");
Console.WriteLine();
Console.WriteLine("Driving");
prvoVozilo.Drive("everywhere");
Console.WriteLine();

Console.WriteLine("od tuka nadolu ke bide tekstot crven".ToColor(ConsoleColor.Red));


var tretoVozilo = listaNaVozila.GetById(3);
Console.WriteLine($"{tretoVozilo.Brand} {tretoVozilo.Model} ({tretoVozilo.Id})");
Console.WriteLine();
Console.WriteLine("Driving:");
tretoVozilo.Drive("nowere, it's French car, It's allways broken");
Console.WriteLine();

var cetvrtoVozilo = listaNaVozila.GetById(4);
Console.WriteLine($"{cetvrtoVozilo.Brand} {cetvrtoVozilo.Model} ({cetvrtoVozilo.Id})");
Console.WriteLine();
Console.WriteLine("Driving car to destination:");
cetvrtoVozilo.Drive("the sunset because it has sunroof");
Console.WriteLine();






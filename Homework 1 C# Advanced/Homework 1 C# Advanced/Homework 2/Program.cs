
using Homework_2.Entities;

// Vtorava domashna do negde ja iskucav, zaglaiv pa se odglaviv so pomosh na chatgpt

Vehicle car = new Car();
Vehicle truck = new Truck();

CarCenter carCenter = new CarCenter();

carCenter.WashCar((Car)car);
Console.WriteLine("Car is now clean.");

carCenter.PumpGas(truck);
Console.WriteLine("Truck now has a full tank of gas.");

carCenter.CheckVehicle(car);
if (car.IsBroken)
{
    carCenter.FixVehicle(car);
    Console.WriteLine("Car has been fixed.");
}
else
{
    Console.WriteLine("Car is in good condition.");
}
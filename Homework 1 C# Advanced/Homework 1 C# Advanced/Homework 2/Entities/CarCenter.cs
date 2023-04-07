using Homework_2.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2.Entities
{
    public class CarCenter : ICarWash, IGasPump, IRepairService
    {
        public ICarWash _carWash;
        public IGasPump _gasPump;
        public IRepairService _repairService;

        public CarCenter()
        {
            _carWash = new CarWash();
            _gasPump = new GasPump();
            _repairService = new RepairService();
        }

        public void WashCar(Car car)
        {
            _carWash.WashCar(car);
        }

        public void WashTruck(Truck truck)
        {
            _carWash.WashTruck(truck);
        }

        public void PumpGas(Vehicle vehicle)
        {
            _gasPump.PumpGas(vehicle);
        }

        public void CheckVehicle(Vehicle vehicle)
        {
            _repairService.CheckVehicle(vehicle);
        }

        public void FixVehicle(Vehicle vehicle)
        {
            _repairService.FixVehicle(vehicle);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace cs_oop_1
{
    public abstract class AbstractCar : IVehicle  //usa interface IVehicle
    {
        public int myProperty => throw new NotImplementedException();

        public int VehicleId { get; }
        public event Action OnStart;

        protected AbstractCar(int vehicleId) {
            VehicleId = vehicleId;
            Console.WriteLine("AbstractCar created");
        }

        public virtual void Start()
        {
            Console.WriteLine("Car starting...");
            OnStart?.Invoke();
        }
        public abstract string GetGpsPosition();

        protected abstract void Refuel();  //abstract method da includere obbligatoriamente from interface
        protected abstract void Recharge();  //abstract method da includere obbligatoriamente from interfaces
        protected void ParkCar()  //normal method, ereditato dalle subclasses
        {
            Console.WriteLine("The abstract car is parking...");
        }


    }
}

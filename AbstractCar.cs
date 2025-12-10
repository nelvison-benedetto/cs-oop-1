using System;
using System.Collections.Generic;
using System.Text;

namespace cs_oop_1
{
    public abstract class AbstractCar : IVehicle  //usa interface IVehicle
    {
        protected AbstractCar() {
            Console.WriteLine("New AbstractCar created.");
        }
        protected abstract void Refuel();  //abstract method da includere obbligatoriamente from interface
        protected abstract void Recharge();  //abstract method da includere obbligatoriamente from interfaces
        protected void ParkCar()  //normal method, ereditato dalle subclasses
        {
            Console.WriteLine("The abstract car is parking...");
        }
    }
}

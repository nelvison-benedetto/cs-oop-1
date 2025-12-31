using System;
using System.Collections.Generic;
using System.Text;

namespace cs_oop_1
{
    public class ElectricCar : AbstractCar
    {
        public string Model { get; }
        public int BatteryLevel { get; private set; }

        //costruttori

        //public ElectricCar(string model) : base()  // chiama il costruttore protected della base
        //{
        //    Model = model;
        //    BatteryLevel = 100;
        //    Console.WriteLine($"ElectricCar {Model} created with full battery.");
        //}        
        public ElectricCar(int id, string model, int batteryLevel = 100 ) : base(id)  // chiama sempre base
        {
            Model = model;
            BatteryLevel = batteryLevel;
            Console.WriteLine($"ElectricCar {Model} created with battery level: {BatteryLevel}%.");
        }

        // Implementazione dei metodi astratti
        protected override void Refuel()
        {
            Console.WriteLine($"{Model} cannot refuel with gas. It's electric!");
        }

        protected override void Recharge()
        {
            BatteryLevel = 100;
            Console.WriteLine($"{Model} recharged to {BatteryLevel}%.");
        }
        public override string GetGpsPosition()
        {
            var pos = new GpsPosition(45.46, 9.18);
            return pos.ToString();
        }

        // Override di un metodo concreto della base se fosse virtual
        // Notiamo che ParkCar non era virtual in AbstractCar, ma possiamo farlo virtual se vogliamo
        public void ParkCarOverride()
        {
            Console.WriteLine($"{Model} is parking automatically.");
        }

        // Override opzionale di start della interface se vogliamo comportamento specifico
        public new void Start()
        {
            Console.WriteLine($"{Model} starting silently...");
            base.Start(); // evento + comportamento base
        }
        

        public override string ToString()
        {
            return $"ElectricCar {Model} | Battery {BatteryLevel}% | Id {VehicleId}";
        }


    }

}

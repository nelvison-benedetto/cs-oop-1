using System;
using System.Collections.Generic;
using System.Text;

namespace cs_oop_1;

public class GasCar : AbstractCar
{
    public string Model { get; }
    public GasCar(int id, string model) : base(id)
    {
        Model = model;
    }
    public override string GetGpsPosition()
    {
        return "GPS unavailable";
    }
    protected override void Recharge()
    {
        Console.WriteLine("Gas car cannot recharge");
    }
    protected override void Refuel()
    {
        Console.WriteLine($"{Model} refueled");
    }
    public override string ToString()
    {
        return $"GasCar {Model} | Id {VehicleId}";
    }
}

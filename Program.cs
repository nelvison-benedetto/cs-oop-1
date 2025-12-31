namespace cs_oop_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<IVehicle> vehicles = new()
            {
                new ElectricCar(1, "Tesla Model 3"),
                new GasCar(2, "BMW X5")
            };

            foreach (var v in vehicles)
            {
                Console.WriteLine(v);           // ToString()
                v.Start();                      // polymorphism
                Console.WriteLine(v.GetGpsPosition());
                v.Stop();
                Console.WriteLine();
            }

            // pattern matching
            foreach (var v in vehicles)
            {
                if (v is ElectricCar ev)
                {
                    Console.WriteLine($"Electric specific: {ev.Model}");
                }
            }

            // static interface method
            IVehicle.printInfoInterface();

        }
    }
}

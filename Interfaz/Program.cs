using System;

namespace InterfazExample
{
    class Program
    {
        static void Main(string[] args)
        {
            IVehicle car = new Car();
            car.StartEngine();
            Console.WriteLine("Velocidad del coche: " + car.GetSpeed());
            car.StopEngine();

            IVehicle bicycle = new Bicycle();
            bicycle.StartEngine();
            Console.WriteLine("Velocidad de la bicicleta: " + bicycle.GetSpeed());
            bicycle.StopEngine();
        }
    }
}

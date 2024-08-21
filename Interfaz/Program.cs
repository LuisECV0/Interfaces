using System;

class Program
{
    static void Main(string[] args)
    {
        IVehicle car = new Car();
        car.StartEngine();
        Console.WriteLine("Car speed: " + car.GetSpeed());

        IVehicle bicycle = new Bicycle();
        bicycle.StartEngine();
        Console.WriteLine("Bicycle speed: " + bicycle.GetSpeed());
    }
}

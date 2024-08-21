using System;

public class Car : IVehicle
{
    private int speed = 0;

    public void StartEngine()
    {
        Console.WriteLine("Car engine started.");
    }

    public void StopEngine()
    {
        Console.WriteLine("Car engine stopped.");
    }

    public int GetSpeed()
    {
        return speed;
    }
}

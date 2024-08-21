﻿using System;

namespace InterfazExample
{
    public class Car : IVehicle
    {
        private int speed = 0;

        public void StartEngine()
        {
            Console.WriteLine("El motor del coche arrancó.");
        }

        public void StopEngine()
        {
            Console.WriteLine("El motor del coche se detuvo.");
        }

        public int GetSpeed()
        {
            return speed;
        }
    }
}

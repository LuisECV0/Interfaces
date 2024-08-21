using System;

namespace InterfazExample
{
    public class Bicycle : IVehicle
    {
        private int speed = 0;

        public void StartEngine()
        {
            Console.WriteLine("La bicicleta no tiene motor, ¡pero puedes empezar a pedalear!");
        }

        public void StopEngine()
        {
            Console.WriteLine("La bicicleta ha dejado de pedalear.");
        }

        public int GetSpeed()
        {
            return speed;
        }
    }
}

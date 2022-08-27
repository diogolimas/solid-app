using System;

namespace Isp.Vehicles
{
    class Motorcycle: IVehicleMotocycle
    {
        private string color;
        private int year;
        private double engine;

        public void ConfigureMotorCycle(string color, int year, double engine)
        {
            this.color = color;
            this.year = year;
            this.engine = engine;

            Console.WriteLine($"Criando um moto {color}, {year}, {engine}, ");
        }


        public void StartVehicle()
        {
            Console.WriteLine("Ligando os motores");
        }
    }
}

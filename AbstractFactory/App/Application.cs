﻿using AbstractFactory.AirCrafts;
using AbstractFactory.Factories;
using AbstractFactory.Landvehicles;

namespace AbstractFactory.App
{
     class Application
     {
        private IAircraft aircraft;
        private ILandVehicle vehicle;

        public Application(ITransportFactory factory)
        { 
            aircraft = factory.CreateTransportAircraft();
            vehicle = factory.CreateTransporteVehicle();
        }

        public void StartRoute()
        {
            vehicle.StartRoute();
            aircraft.StartRoute();
        }


     }
}

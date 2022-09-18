using AbstractFactory.Aircrafts;
using AbstractFactory.AirCrafts;
using AbstractFactory.Landvehicles;

namespace AbstractFactory.Factories
{
    internal class NineNineTransport : ITransportFactory
    {
        public IAircraft CreateTransportAircraft()
        {
            return new Helicopter();
        }

        public ILandVehicle CreateTransporteVehicle()
        {
            return new Motorcycle();
        }
    }
}

using AbstractFactory.Aircrafts;
using AbstractFactory.AirCrafts;
using AbstractFactory.Landvehicles;

namespace AbstractFactory.Factories
{
    class UberTransport : ITransportFactory
    {
        public IAircraft CreateTransportAircraft()
        {
            return new AirPlane();
        }

        public ILandVehicle CreateTransporteVehicle()
        {
            return new Car();
        }
    }
}

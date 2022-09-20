
using BuilderMethod.Products;

namespace BuilderMethod.Components
{
    class VehicleBuilder : IBuilder
    {

        public Vehicle vehicle = new Vehicle();
        public Vehicle GetVehicle()
        {
            Vehicle result = this.vehicle;
            Reset();
            return result;
        }

        public void Reset()
        {
            this.vehicle = new Vehicle();
        }

        public void SetEngine(Engine engine)
        {
            this.vehicle.Engine = engine;
        }

        public void SetSeats(int seats)
        {
            this.vehicle.Seats = seats; 
        }

        public void SetTransmission(Transmission transmission)
        {
            this.vehicle.Transmission = transmission;
        }

        public void SetVehicleType(VehicleType vehicleType)
        {
            this.vehicle.VehicleType = vehicleType;
        }
    }
}


using BuilderMethod.Components;

namespace BuilderMethod.Products
{
    class Vehicle
    {
        private VehicleType vehicleType;

        private int seats;

        private Engine engine;

        private Transmission transmission;
        public VehicleType VehicleType { get => vehicleType; set => vehicleType = value; }  

        public Engine Engine { get => engine; set => engine = value; }  

        public int Seats { get => seats; set => seats = value; }    

        public Transmission Transmission { get => transmission; set => transmission = value; }  
    }
}

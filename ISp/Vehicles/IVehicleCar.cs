namespace Isp.Vehicles
{
    public interface IVehicleCar: IVehicle
    {
        void ConfigureCar(string color, int year, double engine, int seats, int doors);
    }
}

using Isp.Vehicles;
using System;

namespace Isp.Vehicles
{
    public interface IVehicleMotocycle : IVehicle
    {
        void ConfigureMotorCycle(string color, int year, double engine);
    }
}

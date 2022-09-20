using BuilderMethod.Components;
using BuilderMethod.Products;
using System;

namespace BuilderMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VehicleBuilder builder = new VehicleBuilder();

            Director director = new Director(builder);

            director.ConstructSedanCar();

            Vehicle sedan = builder.GetVehicle();

            Console.WriteLine($"Criando um veículo do tipo: {sedan.VehicleType}");

            Console.ReadLine();
        }
    }
}

using System;

namespace FactoryMethod.Vehicle
{
    public class Eats : IVehicle, IFoodDelivery
    {
        public void DeliveriedAt()
        {
            Console.WriteLine("Comida entregue ao destinatário!");
        }

        public void GetCargo()
        {
            Console.WriteLine("Pegamos a comida!");
            DeliveriedAt();
        }

        public void StartRoute()
        {
            Console.WriteLine("Ligando a moto!");
            GetCargo();
        }
    }
}

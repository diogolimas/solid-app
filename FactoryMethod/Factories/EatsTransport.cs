using FactoryMethod.Vehicle;
namespace FactoryMethod.Factories
{
    class EatsTransport : Transport
    {
        protected override IVehicle CreateTransport()
        {
            return new Eats();
        }
    }
}

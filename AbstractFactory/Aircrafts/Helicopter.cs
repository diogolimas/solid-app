using AbstractFactory.AirCrafts;
using System;

namespace AbstractFactory.Aircrafts
{
    class Helicopter : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Verificando ventos, ventos ao sudoeste, ventos OK!");
        }

        public void GetCargo()
        {
            Console.WriteLine("Passageiros ok, ligando as helices!");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Iniciando a decolagem!");
        }
    }
}

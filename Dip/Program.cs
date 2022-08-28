using Dip.Payments;
using System;

namespace Dip
{
    class Program
    {
        static void Main(string[] args)
        {

            PaymentProcess payment = new PaymentProcess();
            payment.Pay("1982471AAA");

            Console.ReadLine();

        }
    }
}

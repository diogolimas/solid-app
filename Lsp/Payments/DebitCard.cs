﻿using System;

namespace Lsp.Payments
{
    class DebitCard : NubankCard
    {

        public override void Validate()
        {
            Console.WriteLine("Validando limite...");
            Console.WriteLine("Limite OK!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace _02_PaymentSystem.Models
{
    internal class CryptoPayment:Payment
    {
        public override void ProcessPayment()
        {
            Console.WriteLine("Crypto ile odenis edildi!");
        }
    }
}

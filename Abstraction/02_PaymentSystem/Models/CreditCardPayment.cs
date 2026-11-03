using System;
using System.Collections.Generic;
using System.Text;

namespace _02_PaymentSystem.Models
{
    internal class CreditCardPayment:Payment
    {
        public override void ProcessPayment()
        {
            Console.WriteLine("Kredit karti ile odenis edildi.");
        }
    }
}

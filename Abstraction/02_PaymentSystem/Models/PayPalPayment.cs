using System;
using System.Collections.Generic;
using System.Text;

namespace _02_PaymentSystem.Models
{
    internal class PayPalPayment:Payment
    {
        public override void ProcessPayment()
        {
            Console.WriteLine("PayPal ile odenis edildi.");
        }
    }
}

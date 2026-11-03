using System;
using System.Collections.Generic;
using System.Text;

namespace _01_OnlinePaymentSystem.Models
{
    internal class PayPalPayment:Payment
    {
        public override void ProcessPayment()
        {
            Console.WriteLine("“PayPal balansından ödeniş uğurla alındı.”");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace _01_OnlinePaymentSystem.Models
{
    internal class CreditCardPayment:Payment
    {

        public override void ProcessPayment()
        {
            Console.WriteLine("Kredit kartı ile ödeniş tesdiqlendi.");
        }
    }
}

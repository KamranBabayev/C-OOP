using System;
using System.Collections.Generic;
using System.Text;

namespace _01_OnlinePaymentSystem.Models
{
    internal class CryptoPayment:Payment
    {
        public override void ProcessPayment()
        {
            Console.WriteLine("“Blockchain üzerindən kripto ödeniş heyata keçirildi.”");
        }
    }
}

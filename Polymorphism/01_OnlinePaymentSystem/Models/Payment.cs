using System;
using System.Collections.Generic;
using System.Text;

namespace _01_OnlinePaymentSystem.Models
{
    internal class Payment
    {
        public decimal Amount { get; set; }
        public virtual void ProcessPayment()
        {
    
            Console.WriteLine("Odenis edilir...");
        }
    }
}

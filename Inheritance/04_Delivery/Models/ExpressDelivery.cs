using System;


namespace Delivery
{
    internal class ExpressDelivery:Delivery
    {
        public int DeliveryTime;

        public ExpressDelivery()
        {
            
        }

        public ExpressDelivery(string id, string customerName, string address, double price,int deliveryTime):base(id,customerName,address,price)
        {
            DeliveryTime = deliveryTime;
             
        }

        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine($"DelieryTime: {DeliveryTime}");
        }

        public void DeliverExpress()
        {
            Console.WriteLine("Sifariş ekspress şəkildə çatdırılır!");
        }
    }
}

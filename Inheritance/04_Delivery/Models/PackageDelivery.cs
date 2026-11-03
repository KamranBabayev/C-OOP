using System;


namespace Delivery
{
    internal class PackageDelivery : Delivery
    {
        public int PackageWeight;
        public string CourierName;

        public PackageDelivery()
        {
            
        }
        public PackageDelivery(string id, string customerName, string address, double price,int packageWeight, string courierName) :base(id,customerName,address,price)
        {
            PackageWeight = packageWeight;
            CourierName = courierName;
        }

        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine($"Package Weight: {PackageWeight}");
            Console.WriteLine($"CourierName: {CourierName}");
        }
        public void DeliverPackage()
        {
            Console.WriteLine("Bağlama kuryer tərəfindən çatdırılır!");

        }
    }
}

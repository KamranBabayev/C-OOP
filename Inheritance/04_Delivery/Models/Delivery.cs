using System;



namespace Delivery
{
    internal class Delivery
    {
        public string Id;

        public string CustomerName;
        public string Address;
        public double Price;

        public Delivery()
        {
            
        }
        public Delivery(string id,string customerName,string address,double price)
        {
            Id = id;
            CustomerName = customerName;
            Address = address;
            Price = price;
        }

        public virtual void ShowDetails()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"CustomerName: {CustomerName}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Price: {Price}");
        }
    }
}

using System;


namespace Delivery
{
    internal class FoodDelivery:Delivery
    {
        public string RestaurantName;
        public FoodDelivery()
        {
            
        }
        public FoodDelivery(string id, string customerName, string address, double price,string restaurantName):base(id,customerName,address,price)
        {
            RestaurantName = restaurantName;
        }

        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine($"RestaurantName: {RestaurantName}");
        }

        public void DeliverFood()
        {
            Console.WriteLine("Yemək restorandan müştəriyə çatdırılır!");
        }
    }
}

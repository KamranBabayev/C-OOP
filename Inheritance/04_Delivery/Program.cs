namespace Delivery;

internal class Program
{
    static void Main(string[] args)
    {
        FoodDelivery food = new FoodDelivery(
            "123567",
            "David",
            "New York street",
            450.0,
            "HoneyPalace"
        );

        PackageDelivery package = new PackageDelivery(
            "345374",
            "John",
            "Washington Street",
            350.0,
            10,
            "Cek"
        );

        ExpressDelivery express = new ExpressDelivery(
            "787907",
            "Trump",
            "Los Angeles city",
            400.0,
            3
        );

        List<Delivery> deliveries = new List<Delivery>();

        deliveries.Add(food);
        deliveries.Add(package);
        deliveries.Add(express);

        foreach (Delivery delivery in deliveries)
        {
            delivery.ShowDetails();
            Console.WriteLine("----------------");
        }

        food.DeliverFood();
        package.DeliverPackage();
        express.DeliverExpress();
    }
}
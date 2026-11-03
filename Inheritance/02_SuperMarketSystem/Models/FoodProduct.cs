using System;


namespace SuperMarketSystem
{
    internal class FoodProduct:Product
    {
        public DateTime ExpirationDate;

        public FoodProduct()
        {
            
        }
        public FoodProduct(string productName, double productPrice ,DateTime expirationDate) :base(productName,productPrice)
        {
            ExpirationDate = expirationDate;

        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"ExpirationDate: {ExpirationDate}");
        }
    }
}

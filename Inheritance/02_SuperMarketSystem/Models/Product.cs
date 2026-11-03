using System;


namespace SuperMarketSystem
{
    internal class Product
    {
        public string ProductName;
        public double ProductPrice;


        public Product()
        {
            
        }
        public Product( string productName,double productPrice)
        {
            ProductName = productName;
            ProductPrice = productPrice;
        }
        public virtual  void ShowInfo()
        {
            Console.WriteLine($"Product name: {ProductName}");
            Console.WriteLine($"Product Price: {ProductPrice}");
        }
    }
}

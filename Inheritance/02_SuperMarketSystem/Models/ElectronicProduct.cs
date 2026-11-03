using System;


namespace SuperMarketSystem
{
    internal class ElectronicProduct:Product
    {
        public int WarrantyMonths;

        public ElectronicProduct()
        {
             
        }
        public ElectronicProduct(string productName, double productPrice, int warrantyMonths):base(productName,productPrice)
        {
            WarrantyMonths = warrantyMonths;
             
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"WarrantyMonths: {WarrantyMonths}");
        }
    }
}

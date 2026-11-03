

namespace _04_TransportSystem.Models
{
    internal class Transport
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public Transport(string brand,string model)
        {
            Brand = brand;
            Model = model;

        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Brand:{Brand}");
            Console.WriteLine($"Model:{Model}");
        }
    }
}

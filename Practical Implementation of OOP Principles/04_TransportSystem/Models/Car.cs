

namespace _04_TransportSystem.Models
{
    internal class Car:Transport
    {
        public int NumberOfWheels { get; set; }

        public Car(string brand, string model, int numberOfWheels) : base(brand, model)
        {
            NumberOfWheels = numberOfWheels;

        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Number Of Wheels: {NumberOfWheels}");
        }
    }
}

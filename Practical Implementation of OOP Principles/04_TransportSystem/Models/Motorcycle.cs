
namespace _04_TransportSystem.Models
{
    internal class Motorcycle:Transport
    {
        public int NumberOfWheels { get; set; }

        public Motorcycle(string brand,string model,int numberOfWheels):base(brand,model)
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

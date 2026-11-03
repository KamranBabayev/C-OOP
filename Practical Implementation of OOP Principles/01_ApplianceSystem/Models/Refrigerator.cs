

namespace _01_ApplianceSystem.Models
{
    internal class Refrigerator:Appliance
    {
        public override void TurnOn()
        {
            Console.WriteLine("Refrigerator is now running");
        }
    }
}

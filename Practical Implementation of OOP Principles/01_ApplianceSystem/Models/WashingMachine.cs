
namespace _01_ApplianceSystem.Models
{
    internal class WashingMachine:Appliance
    {
        public override void TurnOn()
        {
            Console.WriteLine("Washing Machine is now running");
        }
    }
}

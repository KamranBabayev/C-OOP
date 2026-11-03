

namespace _01_ApplianceSystem.Models
{
    abstract class Appliance
    {
        public string Brand { get; set; }
        public int Power { get; set; }

        public abstract void TurnOn();

    }
}

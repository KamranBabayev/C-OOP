using System;


namespace TravelReservationSystem
{
    internal class Wizard:Character
    {
        public string MagicType;

        public Wizard()
        {
            
        }
        public Wizard(string name,int  health,int power,string magicType):base(name,health,power)
        {
            MagicType = magicType;
        }



        public void CastSpell()
        {
            Console.WriteLine("Sehrbaz sehr isledir!");
        }

        public override void ShowStats()
        {
            base.ShowStats();

            Console.WriteLine($"MagicType: {MagicType}");
        }
    }
}

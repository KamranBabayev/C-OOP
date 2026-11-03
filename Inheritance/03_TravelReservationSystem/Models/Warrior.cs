using System;


namespace TravelReservationSystem
{
    internal class Warrior:Character
    {
        public string Weapon;
        public Warrior()
        {
            
        }
        public Warrior(string name, int health, int power,string weapon):base(name,health,power)
        {
            Weapon = weapon;
        }

        public void Attack()
        {
            Console.WriteLine("Döyüşçü silahla hücum edir!");
        }
        public override void ShowStats()
        {
            base.ShowStats();
            Console.WriteLine($"Weapon: {Weapon}");
        }

        
    }
}

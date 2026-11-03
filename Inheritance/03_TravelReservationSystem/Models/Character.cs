using System;


namespace TravelReservationSystem
{
    internal class Character
    {
        public string Name;
        public int  Health;
        public int Power;


        public Character()
        {
             
        }

        public Character(string name,int  health,int power)
        {
            Name = name;
            Health = health;
            Power = power;
        }

        public virtual void ShowStats()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Health: {Health}");
            Console.WriteLine($"Power: {Power}");
        }
    }
}

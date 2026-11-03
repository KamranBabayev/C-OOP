using System;
using System.Collections.Generic;
using System.Text;

namespace _03_AnimalSounds.Models
{
    internal class Cat:IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Cat meows");
        }
    }
}

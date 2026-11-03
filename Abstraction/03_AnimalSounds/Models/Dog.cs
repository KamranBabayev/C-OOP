using System;
using System.Collections.Generic;
using System.Text;

namespace _03_AnimalSounds.Models
{
    internal class Dog:IAnimal
    {
        public  void MakeSound()
        {
            Console.WriteLine("Dog barks");

        }
    }
}

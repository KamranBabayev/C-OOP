using _03_AnimalSounds.Models;

namespace AnimalSounds;

internal class Program
{
    static void Main(string[] args)
    {
        // Task 3.
        //“IAnimal” adlı interface yaz. İçində MakeSound() metodu olsun.
        //Dog və Cat sinifləri bu interfeysi implement etsin.
        //Hər biri öz səsinə uyğun mesaj versin (“Dog barks”, “Cat meows”).
        //Main()də hər iki sinifi çağır.

        Dog dog = new Dog();
        dog.MakeSound();
        Cat cat = new Cat();
        cat.MakeSound();
        
    }
}
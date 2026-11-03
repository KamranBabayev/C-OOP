

using _04_TransportSystem.Models;

namespace TransportSystem;

internal class Program
{
    static void Main(string[] args)
    {

        //Task 4. “Transport” adlı bir base class yaradılır. İçində Brand və Model adlı property-lər və ShowInfo() adlı metod olsun.
        //“Car” və “Motorcycle” adlı iki class bu class-dan miras alsın.
        //Hər biri özünə məxsus NumberOfWheels property-si olsun və ShowInfo() metodunu override edib, markanı, modeli və təkər sayını ekrana çıxartsın.
        //Main() methodunda hər iki sinifdən obyekt yaradılıb məlumatlar ekrana çıxarılsın.
        Car car = new Car("Mercedes", "E300",4);
        car.ShowInfo();

        Motorcycle motor = new Motorcycle("Tufan", "M50",2);
        motor.ShowInfo();
    }
}
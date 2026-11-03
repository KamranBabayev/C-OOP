using _01_ApplianceSystem.Models;

namespace ApplianceSystem;

internal class Program
{
    static void Main(string[] args)
    {
        // Task 1. “Appliance” adlı bir abstract class yaradılır.
        //İçində Brand və Power property - ləri olsun.
        //TurnOn() adlı abstract metod olsun.
        //“WashingMachine” və “Refrigerator” classlari bu class-dan miras alsın
        //və TurnOn() metodunu override etsin(məs: “Washing Machine is now running”).
        //Main() methodunda bu siniflərdən obyekt yaradılıb metodlar çağırılsın.
        WashingMachine wash = new WashingMachine();
        wash.TurnOn();

        Console.WriteLine();

       Refrigerator refrigerator= new Refrigerator();
        refrigerator.TurnOn();
          

    }
}
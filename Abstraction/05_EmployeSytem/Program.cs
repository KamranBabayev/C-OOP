using System;
using _05_EmployeSytem.Models;
namespace EmployeSystem;

internal class Program
{
    static void Main(string[]args)
    {
        //Task 5.
        //Bir şirkətdə müxtəlif növ əməkdaşlar var: FullTimeEmployee və PartTimeEmployee.
        //“Employee” adlı abstract class yaz :
        //Name, Salary adlı property-lər olsun.
        //CalculateBonus() adlı abstract metod olsun.
        //ShowInfo() adlı normal metod olsun və ad +maaş məlumatını ekrana çıxartsın.
        //FullTimeEmployee və PartTimeEmployee sinifləri bu class-dan miras alsın və CalculateBonus() metodunu fərqli qaydada hesablasın:
        //FullTime: maaşın 10%-i qədər bonus
        //PartTime: maaşın 5%-i qədər bonus
        //Main() metodunda hər iki sinifdən obyekt yaradıb həm məlumatı, həm də bonusu ekrana çıxart.


        PartTimeEmployee part = new PartTimeEmployee("Kamran", 500);
        part.ShowInfo();
        Console.WriteLine($"Bonus:{part.CalculateBonus()}");


        FullTimeEmployee full = new FullTimeEmployee("Kamran", 1000);
        full.ShowInfo();
        Console.WriteLine($"Bonus: {full.CalculateBonus()}");

    }
}
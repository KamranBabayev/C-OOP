namespace TravelReservationSystem;

internal class Program
{
    static void Main(string[] args)
    {
        //        Tapşırıq 3 — Oyun personajları
        //Bir oyun üçün siniflər qur.
        //Character adlı əsas sinif yaradın.Bu sinifdə name, health və power adlı sahələr olsun.Həmçinin ShowStats() adlı metod bu məlumatları göstərsin.
        //Warrior və Wizard adlı iki sinif yaradın və Character - dən miras alsınlar.
        //Warrior sinifində weapon adlı sahə olsun və Attack() metodu “Döyüşçü silahla hücum edir!” kimi mesaj versin.
        //Wizard sinifində magicType adlı sahə olsun və CastSpell() metodu “Sehrbaz sehr işlədir!” kimi mesaj versin.
        //Main - də bir Warrior və bir Wizard yaradaraq, onların məlumatlarını göstər və metodlarını çağır.

        Warrior warrior = new Warrior("Kamran", 100, 80, "Sword");
        warrior.ShowStats();

        Console.WriteLine();
        Wizard wizard = new Wizard("Harry", 80, 70, "Fire");
        wizard.ShowStats();

        wizard.CastSpell();

        warrior.Attack();
    }
}
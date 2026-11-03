
namespace SuperMarketSystem;
internal  class Program
{
    static void Main(string[] args)
    {
        //        Tapşırıq 1 — Supermarket sistemini qur
        //Bir supermarket üçün siniflər yarat. Product adlı əsas(base) sinif yaz: məhsulun adını və qiymətini saxlasın, və bir ShowInfo() metodu ilə bu məlumatları göstərsin.
        //FoodProduct və ElectronicProduct adlı iki alt sinif yaradıb Product - dan miras alsınlar.
        //FoodProduct - da əlavə olaraq SonIstifadeTarixi adlı sahə olsun və bu məlumatı ayrıca göstərən metod yaz.
        //ElectronicProduct - da isə ZemanetMuddeti adlı sahə olsun və o da öz metodunda göstərilsin.
        //Main - də hər iki tip məhsuldan bir neçə obyekt yaradaraq məlumatlarını ekrana çıxart.


        FoodProduct food = new FoodProduct("rice", 1.00, new DateTime(2027, 4, 3));
        FoodProduct food1 = new FoodProduct("soap", 2.00, new DateTime(2027,5,4));
        ElectronicProduct electronic = new ElectronicProduct("phone", 400.00, 4);
        ElectronicProduct electronic1 = new ElectronicProduct("Tv", 500.00, 6);
        food.ShowInfo();
        Console.WriteLine();
        food1.ShowInfo();

        Console.WriteLine();
        electronic.ShowInfo();
        Console.WriteLine();
        electronic1.ShowInfo();
    }
}
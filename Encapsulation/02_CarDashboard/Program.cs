using _02_CarDashboard.Models;

namespace _02_CarDashboard;

internal class Program
{
    static void Main(string[] args)
    {
        //CarDashboard adlı bir class yazın. Bu class avtomobilin əsas göstəricilərini təmsil edir və yalnız təhlükəsiz şəkildə dəyişməyə icazə verir.
        //Tələblər:
        //Field-lər(private):
        //_speed — avtomobilin sürəti(int)
        //_fuelLevel — yanacağın miqdarı(int, faizlə)
        //_engineOn — mühərrikin işləyib-işləmədiyini göstərir(bool)

        //Property-lər:
        //- Speed:
        //Dəyər 0 ilə 200 km/saat arasında ola bilər.
        //Əgər bu aralığı keçərsə, ekrana xəbərdarlıq verilsin və dəyər dəyişməsin.
        //Əgər mühərrik söndürülübsə, sürət dəyişməməlidir (ekrana “Engine is OFF!” yazılsın).
        //- FuelLevel:
        //Dəyər 0 ilə 100 arasında ola bilər.
        //Əgər 10%-dən aşağı düşərsə, xəbərdarlıq: “Low fuel!” mesajı çıxsın.

        //Metodlar:
        //StartEngine() — mühərriki işə salır (_engineOn = true), mesaj: “Engine started”
        //StopEngine() — mühərriki söndürür(_engineOn = false, _speed = 0), mesaj: “Engine stopped”
        //ShowStatus() — bütün məlumatları ekrana çıxarır:(Məsələn, Engine: ON, Speed: 80 km/h, Fuel Level: 45%)
         

        CarDashboard car = new CarDashboard(70);
        car.StartEngine();
        car.Speed = 130;
        car.FuelLevel = 9;
        car.ShowStatus();
        car.StopEngine();

        car.ShowStatus();





    }
}


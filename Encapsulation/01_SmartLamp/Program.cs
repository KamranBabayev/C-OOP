using _01_SmartLamp;

namespace _01_SmartLamp.Models;

internal class Program
{
    static void Main(string[] args)
    {
 
        //SmartLamp adlı class yazın. Bu class “ağıllı lampanı” təmsil edir və onun vəziyyətini yalnız təhlükəsiz metodlarla dəyişmək mümkündür.
        //Tələblər:
        //Field-lər (hamısı private olmalıdır):
        //_isOn — lampanın yanıb-yanmadığını göstərir(bool)
        //_brightness — lampanın parlaqlıq səviyyəsi(int)
        //_color — lampanın rəngi(string)

        //Property-lər:
        //- Brightness:
        //Dəyər 0 ilə 100 arasında ola bilər.
        //Əgər bu aralığı keçərsə, ekrana xəbərdarlıq mesajı çıxarılsın və dəyər dəyişməsin.
        //- Color:
        //Boş (empty) string təyin edilə bilməz.
        //Əks halda “Invalid color!” mesajı çıxarılsın.

        //Metodlar:
        //TurnOn() — lampanı yandırır (yalnız isOn = true edir, mesaj çıxarır: “Lamp is ON ”)
        //TurnOff() — lampanı söndürür(mesaj çıxarır: “Lamp is OFF”)
        //ShowStatus() — lampanın hazırki vəziyyətini ekrana çıxarır. (Məsələn, Lamp status: ON, Brightness: 75, Color: Blue)

        SmartLamp lamp = new SmartLamp(75, "Blue");

        lamp.TurnOn();
   

        lamp.Brightness = 90;


        lamp.Color = "Red";


        lamp.ShowStatus();

        lamp.Brightness = 150; // Yanlış parlaqlıq
        lamp.ShowStatus();

        lamp.Color = ""; // Yanlış rəng
        lamp.ShowStatus();

        lamp.TurnOff();
        lamp.ShowStatus();
    }
}
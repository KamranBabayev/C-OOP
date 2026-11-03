

using _02_ShapeSystem.Models;

namespace ShapeSystem;

internal class Program
{
    static void Main(string[] args)
    {
        //Task 2. “Shape” adlı bir base class olsun. 
        //İçində Draw() adlı virtual metod yaz.
        //“Circle”, “Rectangle”, “Triangle” adlı 3 class bu class-dan miras alsın
        //və Draw() metodunu override edib öz fiquruna uyğun mesaj versin(məs: “Drawing Circle”).
        //Main() methodunda Shape tipli bir massiv yaradılır və içində bu obyektlər saxlanılır.
        //Hər biri üçün Draw() çağırılaraq fərqli nəticələr alınır.
        Shape[] shapes =
        {
            new Circle(),
            new Triangle(),
            new Rectangle()
        };
        foreach (var shape in shapes)
        {
            shape.Draw();
        }
    }
}
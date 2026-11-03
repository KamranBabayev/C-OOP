using _04_GeometricShapes.Models;

namespace GeometricsShapes;

internal class Program
{
    static void Main(string[] args)
    {
        //Task 4.
        //IShape adlı bir interface olsun(metod: CalculateArea() və CalculatePerimeter()).
        //Bundan istifadə edən Square və Triangle classları yaradılacaq.
        //Hər biri öz fiqurunun sahəsini və perimetrini hesablama metodlarını override etsin.
        //Main() metodunda bu classlardan obyektlər yaradılıb nəticələr ekrana çıxarılsın.

        Square s = new Square(10);
        Console.WriteLine(s.CalculateArea());
        Console.WriteLine(s.CalculatePerimetr());
        Triangle t = new Triangle(3,4,5);
        Console.WriteLine(t.CalculateArea());
        Console.WriteLine(t.CalculatePerimetr());


    }
}
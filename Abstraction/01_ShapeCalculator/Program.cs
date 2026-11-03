using _01_ShapeCalculator.Models;

namespace ShapeCalculator;

internal class Program
{
    static void Main(string[] args)
    {
        // Task 1.
        //“Shape” adlı bir abstract class yarat.
        //İçində CalculateArea() adlı abstract metod olsun.
        //Bu classdan Circle və Rectangle adlı iki class miras alsın və
        //hər biri CalculateArea() metodunu override etsin.
        //Sonra Main() metodunda hər iki fiqurun sahəsini hesablayıb ekrana çıxart.

        Circle circle = new Circle(5);
        Console.WriteLine($"Circle area: {circle.CalculateArea():F2}");

        Rectangle rectangle = new Rectangle(10, 15);
        Console.WriteLine($"Rectangle area: {rectangle.CalculateArea():F2}");
    }
}
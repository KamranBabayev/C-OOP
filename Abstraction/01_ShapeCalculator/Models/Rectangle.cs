

namespace _01_ShapeCalculator.Models
{
    internal class Rectangle:Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public Rectangle()
        {
            
        }
        public Rectangle(double length,double width)
        {
            Length = length;
            Width = width;
        }
        public override double CalculateArea()
        {
            return Width * Length;
            
        }
    }
}

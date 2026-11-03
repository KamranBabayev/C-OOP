
namespace _04_GeometricShapes.Models
{
    internal class Square:IShape
    {
       public double Side { get; set; }
        public double Area => Side * Side;
        public double Perimetr =>Side * 4;
        public Square(double side)
        {
            Side = side;
            
        }
        public double CalculateArea()
        {
            return Area;
        }
        public double CalculatePerimetr()
        {
            return Perimetr;
        }
    }
}

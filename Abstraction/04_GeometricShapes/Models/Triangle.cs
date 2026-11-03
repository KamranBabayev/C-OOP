using System;
using System.Collections.Generic;
using System.Text;

namespace _04_GeometricShapes.Models
{
    internal class Triangle:IShape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public Triangle(double sideA,double sideB,double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }
        public double CalculatePerimetr()
        {
            return SideA + SideB + SideC;
        }

        public double CalculateArea()
        {
            double p = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(p*(p - SideA) * (p - SideB) * (p - SideC));

        }
    }
}

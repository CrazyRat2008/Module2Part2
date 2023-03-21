using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    internal class Geometry
    {
        public interface IGeometricFigure
        {
            string Abbreviation { get; }
            string Name { get; }
            double CalculateArea();
            double CalculatePerimeter();
            string GetInfo(bool abbreviated = false);
        }

        public class Circle : IGeometricFigure
        {
            public string Abbreviation => "C";
            public string Name => "Circle";
            public double Radius { get; set; }

            public double CalculateArea()
            {
                return Math.PI * Math.Pow(this.Radius, 2);
            }

            public double CalculatePerimeter()
            {
                return 2 * Math.PI * this.Radius;
            }

            public string GetInfo(bool abbreviated = false)
            {
                if (abbreviated)
                {
                    return $"{this.Abbreviation}: Circle";
                }
                else
                {
                    return $"Circle - Radius: {this.Radius}, Area: {this.CalculateArea()}, Perimeter: {this.CalculatePerimeter()}";
                }
            }
        }

        public class Square : IGeometricFigure
        {
            public string Abbreviation => "S";
            public string Name => "Square";
            public double SideLength { get; set; }

            public double CalculateArea()
            {
                return Math.Pow(this.SideLength, 2);
            }

            public double CalculatePerimeter()
            {
                return 4 * this.SideLength;
            }

            public string GetInfo(bool abbreviated = false)
            {
                if (abbreviated)
                {
                    return $"{this.Abbreviation}: Square";
                }
                else
                {
                    return $"Square - Side Length: {this.SideLength}, Area: {this.CalculateArea()}, Perimeter: {this.CalculatePerimeter()}";
                }
            }
        }
    }
}

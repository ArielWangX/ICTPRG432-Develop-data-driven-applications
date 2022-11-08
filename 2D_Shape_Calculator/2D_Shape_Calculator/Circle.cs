using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Shape_Calculator
{
    // Circle class derive from Shape
    public class Circle : Shape
    {
        public double Radius;

        public Circle()
        {
            Radius = 0;
        }

        public Circle(double radius)
        {
            if (radius < 0)
            {
                Radius = 0;
            } else {
                Radius = radius;
            }
            
            
        }

        // inherit from Shape abstract class
        // Area = PI * radius * radius
        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        // Perimeter = PI * radius * 2
        public override double GetPerimeter()
        {
            return Math.PI * Radius * 2;
        }
    }
}

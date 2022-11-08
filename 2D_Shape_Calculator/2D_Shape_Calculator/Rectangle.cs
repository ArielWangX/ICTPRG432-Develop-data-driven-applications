using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Shape_Calculator
{
    // Rectangle class derive from Shape
    public class Rectangle : Shape
    {
        // A rectangle is defined by a length and a height value
        public double Length;
        public double Height;

        public Rectangle()
        {
            Length = 0;
            Height = 0;
        }

        public Rectangle(double length, double height)
        {
            if (length < 0 || height < 0)
            {
                Length = 0;
                Height = 0;
            }
            else {
                Length = length;
                Height = height;
            }
        }

        // inherit from Shape abstract class
        // Area = length * height
        public override double GetArea()
        {
            return Length * Height;
        }

        // Perimeter = (length + height) * 2
        public override double GetPerimeter()
        {
            return (Length + Height) * 2;
        }
    }
}

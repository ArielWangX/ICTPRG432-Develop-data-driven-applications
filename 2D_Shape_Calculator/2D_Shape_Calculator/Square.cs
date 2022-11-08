using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Shape_Calculator
{
    // Square class derive from Shape
    public class Square : Shape
    {
        public double Side;

        public Square()
        {
            Side = 0;
        }

        public Square(double side)
        {
            if (side < 0)
            {
                Side = 0;
            }
            else { 
                Side = side;
            }
        }

        // inherit from Shape abstract class
        // Area = side * side
        public override double GetArea()
        {
            return Side * Side;
        }

        // Perimeter = side * 4
        public override double GetPerimeter()
        {
            return Side * 4;
        }
    }
}

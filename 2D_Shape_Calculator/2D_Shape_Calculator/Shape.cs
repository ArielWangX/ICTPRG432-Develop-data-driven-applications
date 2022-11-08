using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Shape_Calculator
{
    // This is the Shape class. It is the base of all different shapes.
    public abstract class Shape
    {
        public abstract double GetArea();
        public abstract double GetPerimeter();
    }
}

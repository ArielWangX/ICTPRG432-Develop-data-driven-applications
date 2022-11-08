using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Shape_Calculator
{
    // Trapezoid class derive from Shape
    public class Trapezoid : Shape
    {
        public double BaseA;
        public double BaseB;
        public double SideC;
        public double SideD;
        public double HeightH;

        public Trapezoid()
        {
            BaseA = 0;
            BaseB = 0;
            SideC = 0;
            SideD = 0;
            HeightH = 0;
        }

        public Trapezoid(double baseA, double baseB, double sideC, double sideD, double heightH)
        {
            if (baseA < 0 || baseB < 0 || sideC < 0 || sideD < 0 || heightH < 0)
            {
                BaseA = 0;
                BaseB = 0;
                SideC = 0;
                SideD = 0;
                HeightH = 0;
            }
            else {
                BaseA = baseA;
                BaseB = baseB;
                SideC = sideC;
                SideD = sideD;
                HeightH = heightH;
            }
        }

        // inherit from Shape abstract class
        // Area = (BaseA + BaseB) * Height / 2
        public override double GetArea()
        {
            return (BaseA + BaseB) * HeightH / 2;
        }

        // Perimeter = BaseA + BaseB + SideC + SideD
        public override double GetPerimeter()
        {
            return BaseA + BaseB + SideC + SideD;
        }
    }
}

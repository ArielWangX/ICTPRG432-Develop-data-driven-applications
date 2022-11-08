using System;

namespace _2D_Shape_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // define a Shape reference
            Shape shape;

            // define a function - Check the input is exception or not
            static double IsException(string input, double value)
            {
                try
                {
                    value = Double.Parse(input);
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Bye!");
                    Environment.Exit(1);
                }
                value = Double.Parse(input);
                return value;

            }

            // menu to select a shape
            Console.WriteLine("Select a shape : \n1 - Square \n2 - Rectangle \n3 - Circle \n4 - Trapezoid");
            string type = Console.ReadLine();
 
            switch (type)
            {
                case "1":
                    // if Square, get side
                    Console.WriteLine("Set square side");
                    string sideInput = Console.ReadLine();
 
                    double squareSide = 0.0;
                    squareSide = IsException(sideInput, squareSide);

                    shape = new Square(squareSide);
                    break;

                case "2":
                    // if Rectangle, get length and height
                    // get length
                    Console.WriteLine("Set rectangle length");
                    string lengthInput = Console.ReadLine();
 
                    double rectangleLength = 0.0;
                    rectangleLength = IsException(lengthInput, rectangleLength);

                    // get height
                    Console.WriteLine("Set rectangle height");
                    string heightInput = Console.ReadLine();
 
                    double rectangleHeight = 0.0;
                    rectangleHeight = IsException(heightInput, rectangleHeight);

                    shape = new Rectangle(rectangleLength, rectangleHeight);
                    break;

                case "3":
                    // if Circle, get radius
                    Console.WriteLine("Set circle radius");
                    string radiusInput = Console.ReadLine();

                    double circleRadius = 0.0;
                    circleRadius = IsException(radiusInput, circleRadius);

                    shape = new Circle(circleRadius);
                    break;

                case "4":
                    // if Trapezoid, get baseA, baseB, sideC, sideD and height
                    // get baseA
                    Console.WriteLine("Set trapezoid base a");
                    string baseAInput = Console.ReadLine();

                    double trapezoidBaseA = 0.0;
                    trapezoidBaseA = IsException(baseAInput, trapezoidBaseA);

                    // get baseB
                    Console.WriteLine("Set trapezoid base b");
                    string baseBInput = Console.ReadLine();

                    double trapezoidBaseB = 0.0;
                    trapezoidBaseB = IsException(baseBInput, trapezoidBaseB);

                    // get sideC
                    Console.WriteLine("Set trapezoid side c");
                    string sideCInput = Console.ReadLine();

                    double trapezoidSideC = 0.0;
                    trapezoidSideC = IsException(sideCInput, trapezoidSideC);

                    // get sideD
                    Console.WriteLine("Set trapezoid side d");
                    string sideDInput = Console.ReadLine();

                    double trapezoidSideD = 0.0;
                    trapezoidSideD = IsException(sideDInput, trapezoidSideD);

                    // get height
                    Console.WriteLine("Set trapezoid height");
                    string heightHInput = Console.ReadLine();

                    double trapezoidHeight = 0.0;
                    trapezoidHeight = IsException(heightHInput, trapezoidHeight);

                    shape = new Trapezoid(trapezoidBaseA, trapezoidBaseB, trapezoidSideC, trapezoidSideD, trapezoidHeight);
                    break;

                default:
                    Console.WriteLine("Wrong Selection. Bye");
                    return;
            }

            // menu to select what to solve
            Console.WriteLine("Solve for:  \n1 - Area  \n2 - Perimeter");
            string operation = Console.ReadLine();

            switch (operation)
            {
                case "1":
                    // solve area
                    Console.WriteLine("Area is: " + shape.GetArea());
                    break;

                case "2":
                    // solve perimeter
                    Console.WriteLine("Perimeter is: " + shape.GetPerimeter());
                    break;

                default:
                    Console.WriteLine("Wrong Selection. Bye");
                    return;

            }

        }
    }
}

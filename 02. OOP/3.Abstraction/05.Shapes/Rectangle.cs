using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Shapes
{
    public class Rectangle : Shape
    {
        public Rectangle(double a, double b)
        {
            A = a;
            B = b;
        }

        public double A { get; private set; }
        public double B { get; private set; }

        public override double calculateArea()
        {
            return A * B;
        }

        public override double calculatePerimeter()
        {
            return 2 * A + 2 * B;
        }

        public override string Draw()
        {
            return $"Drawing {GetType().Name}...";
        }
    }
}

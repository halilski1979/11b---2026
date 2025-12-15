using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Shapes
{
    public class Rectangle : Shape
    {
        public double A { get; set; }
        public double B { get; set; }
        public Rectangle(double a, double b)
        {
            A = a;
            B = b;
        }

        
        public override double CalculateArea()
        {
            double result = A * B;
            return result;
        }

        public override double CalculatePerimeter()
        {
            double result = (2 * A) + (2 * B);
            return result;
        }
        public virtual string Draw()
        {
            return base.Draw() + $"{GetType().Name}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Shapes
{
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }

       
        public override double CalculateArea()
        {
            double result = Math.PI * Radius * Radius;
            return result;
        }

        public override double CalculatePerimeter()
        {
            double result = 2 * Math.PI * Radius;
            return result;
        }
        public virtual string Draw()
        {
            return base.Draw() + $"{GetType().Name}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._Figurs
{
    internal class Circle : IDrawable, IArea, IPerimeter
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public void Area()
        {
            double area = Math.PI * Radius * Radius;
            Console.WriteLine($"Circle area: {area:f2}");
        }

        public void Draw()
        {
            Console.WriteLine($"I draw {GetType().Name} with radius {Radius}");
        }

        public void Perimeter()
        {
            double perimeter = 2 * Math.PI * Radius;
            Console.WriteLine($"Circle perimeter: {perimeter:f2}");
        }
    }
}

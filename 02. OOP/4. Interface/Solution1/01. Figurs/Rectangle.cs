using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._Figurs
{
    internal class Rectangle : IDrawable, IArea, IPerimeter
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

       

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public void Area()
        {
            double area = Height * Width;
            Console.WriteLine($"Rectangle area: {area:f2}");
        }

        public void Draw()
        {
            Console.WriteLine($"I draw {GetType().Name} with a={Width} , b={Height}");
        }

        public void Perimeter()
        {
            double perimeter = (2 * Width) + (2 * Height);
            Console.WriteLine($"Rectangle perimeter: {perimeter:f2}");
        }
    }
}

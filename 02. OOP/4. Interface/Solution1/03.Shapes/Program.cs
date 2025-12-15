using System.Runtime.CompilerServices;

namespace _03.Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            var cmd = Console.ReadLine().Split(' ').ToList();
            while (cmd[0] != "End") 
            {
                if (cmd.Count == 2)
                {
                    Shape c = new Circle(double.Parse(cmd[1]));
                    //Console.WriteLine($"Circle perimeter - {c.CalculatePerimeter():f2}");
                    
                    //Console.WriteLine($"Circle area - {c.CalculateArea():f2}");
                    shapes.Add(c);  
                }
                else if (cmd.Count == 3)
                {
                    Shape r = new Rectangle(double.Parse(cmd[1]), double.Parse(cmd[2]));
                    //Console.WriteLine($"Rectangle perimeter - {r.CalculatePerimeter():f2}");
                    
                    //Console.WriteLine($"Rectangle area - {r.CalculateArea():f2}");
                    shapes.Add(r);  
                }
                cmd = Console.ReadLine().Split(' ').ToList();

            }
            foreach (var item in shapes)
            {
                Console.WriteLine(item.CalculateArea());
                Console.WriteLine(item.CalculatePerimeter());
            }
            
        }
    }
}

namespace _05.Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Shape> shapes = new List<Shape>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Vuvedi figura: rectangle/circle");
                string typeFigure = Console.ReadLine();

                if (typeFigure == "rectangle")
                {
                    Console.WriteLine("Vuvedi strana A:");
                    double a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Vuvedi strana B:");
                    double b = double.Parse(Console.ReadLine());

                    Shape rectangle = new Rectangle(a, b);
                    shapes.Add(rectangle);
                }

                if (typeFigure == "circle")
                {
                    Console.WriteLine("Vuvedi radius:");
                    double r = double.Parse(Console.ReadLine());                    

                    Shape circle = new Circle(r);
                    shapes.Add(circle);
                }
            }
            foreach (var item in shapes)
            {
                Console.WriteLine(item.Draw());
                Console.WriteLine($"P = {item.calculatePerimeter():f2}");
                Console.WriteLine($"S = {item.calculateArea():f2}");
            }
        }
    }
}

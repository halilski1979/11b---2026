namespace _01._Figurs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(3.3);
            circle.Draw();
            circle.Area();
            circle.Perimeter();

            Rectangle rect = new Rectangle(3,4.7);
            rect.Draw();
            rect.Area();
            rect.Perimeter();
        }
    }
}

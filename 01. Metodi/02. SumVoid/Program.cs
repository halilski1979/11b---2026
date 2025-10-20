namespace _02._SumVoid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sum();
        }

        private static void Sum()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double s = a + b;
            Console.WriteLine(s);
        }
    }
}

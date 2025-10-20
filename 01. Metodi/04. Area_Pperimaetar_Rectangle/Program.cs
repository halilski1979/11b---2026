namespace _04._Area_Pperimaetar_Rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rect();
        }

        public static void Rectangle(double a, double b)
        {
            Console.WriteLine($"S={a*b}");
            Console.WriteLine($"P={2*a+2*b}");
        }

        public static void Rect()
        {
            Console.WriteLine("Vavedete strani za pravoagalnik: ");

            Console.Write("a=");
            double a=double.Parse( Console.ReadLine() );

            Console.Write("b=");
            double b=double.Parse( Console.ReadLine() );


            Console.WriteLine($"S={a * b}");
            Console.WriteLine($"P={2 * a + 2 * b}");

        }
    }
}

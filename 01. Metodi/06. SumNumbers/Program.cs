namespace _06._SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {          
            Console.WriteLine(Suma(3, 4));
        }

        public static int Sum()
        {
            Console.Write("a=");
            int a=int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());

            return a + b;
        }

        public static int Suma(int a, int b)
        {
            return a + b;
        }
    }
}

namespace _03.SumVoid_Parametar
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Sum(5.2,6.77);
        }

        public static void Sum(double a, double b)
        {
            double s = a + b;
            Console.WriteLine(s);
        }
    }
}

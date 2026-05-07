namespace _15._2___Stepen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vuvedete osnova: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Vuvedete stepen: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Otgovor: {Stepen(a, n)}");
        }

        public static int Stepen(int a, int n)
        {
            if (n == 0)
            {
                return 1;
            }

            return a * Stepen(a, n - 1);
        }
    }
}

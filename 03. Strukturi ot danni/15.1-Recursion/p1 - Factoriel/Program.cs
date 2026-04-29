namespace p1___Factoriel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factoriel(4));
        }

        public static void Fact(int n)
        {
            int factoriel = 1;
            for (int i = 1; i <= n; i++)
            {
                factoriel *= i;
            }
            Console.WriteLine(factoriel);
        }

        public static int Factoriel(int n)
        {
            if (n==0)
            {
                return 1;
            }

            return n * Factoriel(n-1);
        }
    }
}

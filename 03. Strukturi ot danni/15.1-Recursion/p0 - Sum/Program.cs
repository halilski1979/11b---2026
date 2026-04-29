namespace p0___Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumRecursia(0)); 
        }

        public static void Sum(int n)
        {
            int s = 0;
            for (int i = 0; i <= n; i++)
            {
                s += i;
            }
            Console.WriteLine(s);
        }

        public static int SumRecursia(int n)
        {
            if (n == 1)
                return 1;

            return n + SumRecursia(n - 1);
        }
    }
}

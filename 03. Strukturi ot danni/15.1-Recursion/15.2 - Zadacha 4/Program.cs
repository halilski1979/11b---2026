namespace _15._2___Zadacha_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Recursion(n);
        }
        public static void ToN(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void Recursion(int n)
        {
            if (n == 0)
            {
                return;
            }
            Recursion(n-1);
            Console.WriteLine(n);
        }
    }
}

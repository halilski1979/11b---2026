namespace _05._SumCifri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sum(int.Parse(Console.ReadLine()));
        }

        public static void Sum(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                
                sum += n % 10;
                n = n / 10;
                
            }
            Console.WriteLine(sum);
        }
    }
}

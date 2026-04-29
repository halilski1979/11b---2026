namespace z1___Fibonachi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());

            long result = Fibonacci(n);
            Console.WriteLine($"{n}-toto chislo na Fibonachi e: {result}");
        }

        static long Fibonacci(int n)
        {
            
            if (n == 1 || n == 2)
            {
                return 1;
            }           
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}

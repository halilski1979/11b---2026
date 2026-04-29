namespace z2___Stepen
{
    internal class Program
    {
        
        
        static void Main(string[] args)
        {
            Console.WriteLine(Power(2, 3));
        }

        static double Power(double a, int n)
        {
            if (n == 0)
                return 1;

            return a * Power(a, n - 1);
        }
    }
}

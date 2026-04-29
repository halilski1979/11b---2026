namespace z3___SumCifri_Na_Chislo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 5042;
            Console.WriteLine($"Sumata na  {number} e: {SumDigits(number)}");
        }

        static int SumDigits(int n)
        {
             if (n < 10)
                return n;
            
            return (n % 10) + SumDigits(n / 10);
        }
    }
}

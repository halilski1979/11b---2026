namespace _15._2_Zadacha_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(RecursionDigit(number));
        }
        public static int RecursionDigit(int n)
        {
            if (n<=0)
            {
                return 0;
            }
            return n%10
                +RecursionDigit(n/10);
        }
    }
}

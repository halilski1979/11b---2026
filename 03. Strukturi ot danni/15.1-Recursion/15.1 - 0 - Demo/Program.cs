namespace _15._1___0___Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Sum(3));
        }

        public static int Sum(int n)
        {
            if (n == 1)
                return 1; //Дъно на рекурсия

            return n + Sum(n - 1);
        }
    }
}

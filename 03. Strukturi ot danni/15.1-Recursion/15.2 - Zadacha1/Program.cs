namespace _15._2___Zadacha1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fibonacci(7));
        }
        public static int Fibonacci(int n)
        {
            if(n==1|| n==2)
                return 1;
            return Fibonacci(n-1) + Fibonacci(n-2);
            
        }


       
    }
}

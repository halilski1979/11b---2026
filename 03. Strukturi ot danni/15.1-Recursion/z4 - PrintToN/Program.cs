namespace z4___PrintToN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintUpToN(5);
        }

        static void PrintUpToN(int n)
        {
            if (n <= 0) return;

            PrintUpToN(n - 1); 
            Console.Write(n + " "); 
        }
    }
}

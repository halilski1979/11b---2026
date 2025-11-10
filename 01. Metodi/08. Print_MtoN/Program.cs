namespace _08._Print_MtoN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Print(5,10);
        }

        public static void Print(int start, int end)
        {
            for (int i = start; i <=end; i++)
            {
                Console.WriteLine(i); 
            }
        }
    }
}

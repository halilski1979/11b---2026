namespace p01___Zadacha4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var cmd = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(i * 5);
            }
        }
    }
}

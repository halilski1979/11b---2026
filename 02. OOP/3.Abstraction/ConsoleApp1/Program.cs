namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<double, double> addVat = p => p * 1.2;
            double[] prices = Console.ReadLine()
                .Split(new string[] { ", " },
                    StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(addVat)
                .ToArray();
            foreach (var price in prices)
                Console.WriteLine($"{price:f2}");

        }
    }
}

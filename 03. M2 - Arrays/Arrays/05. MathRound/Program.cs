namespace _05._MathRound
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers=Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            //0.9 => 1

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{numbers[i]} => {Math.Round(numbers[i])}");
            }
        }
    }
}

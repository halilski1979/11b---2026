namespace _01._Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = 1;
            }

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"numbers[{i}]={numbers[i]}");
            }

        }
    }
}

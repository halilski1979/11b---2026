namespace _10._ListParametar
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            var numbers=Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            PrintCh(numbers);
        }

        private static void PrintChetni()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
        }

        public static void PrintCh(List<int> num)
        {
            for (int i = 0; i < num.Count; i++)
            {
                if (num[i]%2==0)
                {
                    Console.WriteLine(num[i]);
                }
            }
        }
    }
}

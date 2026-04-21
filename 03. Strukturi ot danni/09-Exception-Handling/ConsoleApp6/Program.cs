namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = 1;
            int end = 100;

            List<int> list = new List<int>();  

            while (list.Count < 10)
            {
                try
                {
                    int num = ReadNumber(start, end);
                    list.Add(num);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message); 
                }
            }
            Console.WriteLine(string.Join(", ", list));
        }

        public static int ReadNumber(int start, int end)
        {
            try
            {
                int input = int.Parse(Console.ReadLine());

                if (input <= start || input >= end)
                {
                    throw new ArgumentException($"Your number is not in range ({start} - {end})");
                }
                return input;
            }
            catch (FormatException ex)
            {
                throw new FormatException("Invalid number");
            }
        }
    }
}

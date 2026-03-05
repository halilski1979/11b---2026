namespace _5._1___z2___BroyBukvi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<char, int> counts = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (c == ' ') continue; // игнорирай интервалите

                if (counts.ContainsKey(c))
                    counts[c]++;
                else
                    counts[c] = 1;
            }

            foreach (var item in counts)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}

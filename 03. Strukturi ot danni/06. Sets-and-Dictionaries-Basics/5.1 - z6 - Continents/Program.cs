namespace _5._1___z6___Continents
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var continents = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] parts = Console.ReadLine().Split();
                string continent = parts[0];
                string country = parts[1];
                string city = parts[2];

                if (!continents.ContainsKey(continent))
                    continents[continent] = new Dictionary<string, List<string>>();

                if (!continents[continent].ContainsKey(country))
                    continents[continent][country] = new List<string>();

                continents[continent][country].Add(city);
            }

            // Отпечатваме резултата
            foreach (var continent in continents)
            {
                Console.WriteLine($"{continent.Key}:");
                foreach (var country in continent.Value)
                {
                    Console.WriteLine($"  {country.Key} -> {string.Join(", ", country.Value)}");
                }
            }
        }
    }
}

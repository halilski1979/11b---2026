using System.ComponentModel.DataAnnotations.Schema;

namespace _100_5._1_zad6___COntinents
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string,Dictionary<string,List<string>>> continents=new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ').ToList();
                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (!continents.ContainsKey(continent))
                {
                    continents[continent] = new Dictionary<string, List<string>>();
                }

                if (!continents[continent].ContainsKey(country))
                {
                    continents[continent][country] = new List<string>();
                }

                continents[continent][country].Add(city);
            }

            foreach (var item in continents)
            {
                Console.WriteLine($"{item.Key}:");

                foreach (var country in item.Value)
                {
                    Console.WriteLine($" {country.Key} -> {string.Join(" ,",country.Value)}");
                }
            }

        }
                
    }
}

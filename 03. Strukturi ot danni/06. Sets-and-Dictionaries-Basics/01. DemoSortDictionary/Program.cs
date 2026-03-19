namespace _01._DemoSortDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> people = new Dictionary<string, double>();
            people["Ivan"] = 1000;
            people["Georgi"] = 2000;
            people["Dospatliyski"] = 10000;
            people.Add("Gabi",100);
            people.Add("Aleks",10);

            foreach (var person in people)
            {
                Console.WriteLine($"{person.Key} => {person.Value}");
            }

            Console.WriteLine();
            var sortedByKey = people.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            foreach (var person in sortedByKey)
            {
                Console.WriteLine($"{person.Key} => {person.Value}");
            }
        }
    }
}

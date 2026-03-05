namespace _01._Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> fruits = new Dictionary<string, double>();
            fruits["banana"] = 2.20;
            fruits["apple"] = 1.40;
            fruits["kiwi"] = 3.20;
            fruits.Add("lemon",3.50);
            fruits.Add("Melon", 4.50);

            //Print 1
            foreach (var item in fruits)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

            Console.WriteLine();
            //Print2
            fruits.ToList().ForEach(f => Console.WriteLine($"{f.Key} costs {f.Value}"));

            Console.WriteLine();
            //Print3
            Console.WriteLine(string.Join(", ", fruits.Select(x => $"{x.Key}: {x.Value}")));

            Console.WriteLine();
            //Print4
            Console.WriteLine(string.Join("\n", fruits.Select(x => $"{x.Key}: {x.Value}")));
        }
    }
}

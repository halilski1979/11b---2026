namespace _02._Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> fruits = new Dictionary<string, double>();
            fruits["banana"] = 2.20;
            fruits["apple"] = 1.40;
            fruits["kiwi"] = 3.20;
            fruits.Add("lemon", 3.50);
            fruits.Add("Melon", 4.50);          

            var sortedByKey = fruits.OrderBy(x => x.Key)
                        .ToDictionary(x => x.Key, x => x.Value);

            var sortedByValue = fruits.OrderBy(f => f.Value)
                          .ToDictionary(f => f.Key, f => f.Value);



            //Print 1
            foreach (var item in fruits)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}

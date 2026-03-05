namespace _5._1___z4___HranitelenMagazin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stores = new Dictionary<string, Dictionary<string, double>>();
            string input;

            while ((input = Console.ReadLine()) != "Revision")
            {
                string[] parts = input.Split(", ");
                string store = parts[0];
                string product = parts[1];
                double price = double.Parse(parts[2]);

                if (!stores.ContainsKey(store))
                    stores[store] = new Dictionary<string, double>();

                stores[store][product] = price; // добавяме или обновяваме цената
            }

            // Сортираме магазините по име
            foreach (var store in stores.OrderBy(s => s.Key))
            {
                Console.WriteLine($"{store.Key}->");
                foreach (var product in store.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}

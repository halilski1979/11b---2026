namespace _6._1___z4____Products
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Речник: име (string) -> данни [цена, количество] (List<double>)
            Dictionary<string, List<double>> products = new Dictionary<string, List<double>>();

            
            while (true)
            {
                var input = Console.ReadLine().Split(' ').ToList();

                if (input[0]=="buy")
                {
                    break;
                }

                
                string name = input[0];
                double price = double.Parse(input[1]);
                double quantity = double.Parse(input[2]);

                if (!products.ContainsKey(name))
                {
                    // Добавяме нов продукт със списък от две стойности
                    products[name] = new List<double> { price, quantity };
                }
                else
                {
                    // Променяме цената (индекс 0) и добавяме към количеството (индекс 1)
                    products[name][0] = price;
                    products[name][1] += quantity;
                }
            }

            // Обхождаме речника и изчисляваме общата сума
            foreach (var item in products)
            {
                string name = item.Key;
                double totalPrice = item.Value[0] * item.Value[1];

                Console.WriteLine($"{name} -> {totalPrice:F2}");
            }
        }
    }
}

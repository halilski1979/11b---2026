namespace _100___5._1___z4___Products
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,List<double>> products= new Dictionary<string,List<double>>();
            while (true)
            {
                var input = Console.ReadLine().Split(' ').ToList();
                if (input[0]=="buy")
                {
                    break;
                }

                string name= input[0];
                double price=double.Parse(input[1]);
                double quantity=double.Parse(input[2]);

                if (!products.ContainsKey(name))
                {
                    products[name] = new List<double>() {price,quantity};
                }
                else
                {
                    products[name][0] = price;
                    products[name][1] += quantity;
                }
            }

            foreach (var item in products)
            {
                string name=item.Key;
                double totalPrice = item.Value[0]*item.Value[1];
                Console.WriteLine($"{name} -> {totalPrice:f2}");
            }
        }
    }
}

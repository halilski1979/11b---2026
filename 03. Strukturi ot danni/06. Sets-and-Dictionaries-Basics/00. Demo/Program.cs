namespace _00._Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];
            SortedDictionary<string,double> fruits=new SortedDictionary<string,double>();

            num[0] = 1;
            num[1]=12;           


            fruits["banana"] = 2.20;
            fruits["kiwi"] = 2.40;
            fruits["apple"] = 3.20;

            foreach (var item in fruits)
            {
                Console.WriteLine($"{item.Key} => {item.Value} Euro");
            }

            //Методи
            Console.WriteLine();
            fruits.Add("grapes",2.55);
            fruits.Add("watermelon",4.22);
            foreach (var item in fruits)
            {
                Console.WriteLine($"{item.Key} => {item.Value} Euro");
            }

            Console.WriteLine();
            fruits.Remove("banana");
            foreach (var item in fruits)
            {
                Console.WriteLine($"{item.Key} => {item.Value} Euro");
            }

            Console.WriteLine($"Banana {fruits.ContainsKey("banana")}");
            Console.WriteLine($"Apllle {fruits.ContainsKey("apple")}");

            fruits.TryGetValue("apple", out double p);
            Console.WriteLine(p);

            fruits.ToList();
            foreach (var item in fruits)
            {
                Console.WriteLine($"FruitsToList: {item}");
            }
        }
    }
}

namespace _5._1___z1___SreshtaniaChislo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double[] numbers = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);
           
            Dictionary<double, int> counts = new Dictionary<double, int>();

            foreach (var num in numbers)
            {
                if (counts.ContainsKey(num))
                    counts[num]++;       
                else
                    counts[num] = 1;    
            }
            
            foreach (var kvp in counts)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value} times");
            }
        }
    }
}

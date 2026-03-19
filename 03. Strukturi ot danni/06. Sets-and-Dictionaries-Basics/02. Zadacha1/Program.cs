namespace _02._Zadacha1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            Dictionary<double,int> counts= new Dictionary<double,int>();
            
            foreach (var i in num)
            {
                if (!counts.ContainsKey(i))
                {
                    counts.Add(i,1);
                }
                else
                {
                    counts[i]++;
                }
            }

            foreach (var item in counts)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }

        }
    }
}

namespace _03._Zadacha3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input= Console.ReadLine();

            Dictionary<char,int> counts= new Dictionary<char,int>();
            
            foreach (var item in input)
            {
                if (item==' ')
                {
                    continue;
                }

                if (counts.ContainsKey(item))
                {
                    counts[item]++;
                }
                else
                {
                    counts.Add(item, 1);
                }
            }

            foreach (var item in counts)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }


        }
    }
}

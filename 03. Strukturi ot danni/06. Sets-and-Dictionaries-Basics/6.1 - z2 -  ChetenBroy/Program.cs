namespace _6._1___z2____ChetenBroy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<int, int> counts = new Dictionary<int, int>();

            // Прочитане на числата и попълване на речника
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (counts.ContainsKey(num))
                {
                    counts[num]++;
                }
                else
                {
                    counts[num] = 1;
                }
            }

            // Намиране на числото с четен брой срещания
            foreach (var item in counts)
            {
                if (item.Value % 2 == 0)
                {
                    Console.WriteLine(item.Key);
                   // break;
                }
            }
        }
    }
}

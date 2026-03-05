namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] first = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] second = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool proverkaVqrno = true;
            foreach (int i in second) 
            {
                if (!first.Contains(i))
                {
                    proverkaVqrno = false;
                    break;
                }
            }
            if (proverkaVqrno == true)
            {
                Console.WriteLine("Yes");
            }
            else if (proverkaVqrno == false)
            {
                Console.WriteLine("No");
            }
        }
    }
}

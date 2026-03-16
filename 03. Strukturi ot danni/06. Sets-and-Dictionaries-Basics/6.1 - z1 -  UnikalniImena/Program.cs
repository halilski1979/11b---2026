namespace _6._1___z1____UnikalniImena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedSet<string> elements = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] compounds = Console.ReadLine().Split();
                foreach (string element in compounds)
                {
                    elements.Add(element); // добавя само уникални елементи
                }
            }

            Console.WriteLine(string.Join(" ", elements));
        }
    }
}

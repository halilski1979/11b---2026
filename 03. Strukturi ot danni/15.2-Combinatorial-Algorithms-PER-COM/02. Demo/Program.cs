namespace _02._Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] elements = { 'A', 'B', 'C','D'};
            Console.WriteLine("Permutaciite sa:");
            Permute(elements, 0, elements.Length - 1);
        }

        static void Permute(char[] list, int k, int m)
        {
            if (k == m)
            {
                Console.WriteLine(string.Join(" ", list));
            }
            else
            {
                for (int i = k; i <= m; i++)
                {
                    Swap(ref list[k], ref list[i]);
                    Permute(list, k + 1, m);
                    Swap(ref list[k], ref list[i]); // Връщане назад (backtracking)
                }
            }
        }

        static void Swap(ref char a, ref char b)
        {
            if (a == b) return;
            char temp = a;
            a = b;
            b = temp;
        }
    }
}

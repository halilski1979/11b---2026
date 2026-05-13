namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] elements = { 'a', 'a','d'};
            Permute(elements, 0, elements.Length-1);
        }

        public static void Permute(char[] list, int k, int n)
        {
            if (k==n)
            {
                Console.WriteLine(string.Join(" ",list));
            }
            else
            {
                for (int i = k; i <=n ; i++)
                {
                    Swap(ref list[k],ref list[i]);
                    Permute(list, k+1, n);
                    Swap(ref list[k],ref list[i]);
                }
            }
        }

        public static void Swap(ref char a, ref char b)
        {
            if (a == b) return;
            {
                char temp= a;
                a= b;
                b= temp;
            }
        }
    }
}

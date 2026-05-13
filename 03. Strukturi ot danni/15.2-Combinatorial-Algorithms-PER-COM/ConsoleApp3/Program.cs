namespace ConsoleApp3
{
    internal class Program
    {
        static char[] elements = { 'a', 'b', 'c' };
        static int count = 0;
        static void Main(string[] args)
        {
            Permute(0);
            Print();
        }

        static void Permute(int index)
        {
            if (index >= elements.Length)
            {
                Print();
            }
            else
            {
                Permute(index + 1);

                for (int i = index + 1; i < elements.Length; i++)
                {
                    Swap(index, i);
                    Permute(index + 1);
                    Swap(index, i);
                }
            }
        }

        public static void Swap(int first, int second)
        {
            char temp = elements[first];
            elements[first] = elements[second];
            elements[second] = temp;
        }

        public static void Print()
        {
            Console.WriteLine(string.Join(' ', elements));
            count++;
        }
    }
}

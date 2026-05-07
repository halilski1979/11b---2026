namespace _03._Demo___Per_S_Povtoreniq
{
    internal class Program
    {
        private static string[] elements;
        static void Main(string[] args)
        {
            // Можете да промените елементите тук
            elements = new string[] { "A", "A", "C","B" };
            Permute(0);
        }

        static void Permute(int index)
        {
            if (index >= elements.Length)
            {
                Print();
                return;
            }

            Permute(index + 1);

            var swapped = new HashSet<string> { elements[index] };

            for (int i = index + 1; i < elements.Length; i++)
            {
                if (!swapped.Contains(elements[i]))
                {
                    Swap(index, i);
                    Permute(index + 1);
                    Swap(index, i); // Backtracking
                    swapped.Add(elements[i]);
                }
            }
        }

        static void Swap(int first, int second)
        {
            var temp = elements[first];
            elements[first] = elements[second];
            elements[second] = temp;
        }

        static void Print()
        {
            Console.WriteLine(string.Join(" ", elements));
        }
    }
}

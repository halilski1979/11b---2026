using System.Xml.Linq;

namespace _04._Demo_Variacii
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Променливите са дефинирани локално в Main
            string[] elements = { "A", "B", "C" };
            int k = 2;

            string[] variations = new string[k];
            bool[] used = new bool[elements.Length];

            // Подаваме ги като аргументи на функцията
            GenerateVariations(0, elements, variations, used);
        }

        // Функцията е извън Main и приема всичко необходимо чрез параметри
        static void GenerateVariations(int index, string[] elements, string[] variations, bool[] used)
        {
            if (index >= variations.Length)
            {
                Console.WriteLine(string.Join(" ", variations));
                return;
            }

            for (int i = 0; i < elements.Length; i++)
            {
                if (!used[i])
                {
                    used[i] = true;
                    variations[index] = elements[i];

                    // Предаваме ги надолу по рекурсията
                    GenerateVariations(index + 1, elements, variations, used);

                    used[i] = false;
                }
            }
        }
    }
}

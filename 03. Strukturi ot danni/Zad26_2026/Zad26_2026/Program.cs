namespace Zad26_2026
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numbers=int.Parse(Console.ReadLine());
            int[]elements=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            if (elements.Length!=numbers)
            {
                Console.WriteLine("Невалиден вход");
                return;
            }
            int len = 1;
            int start = 0;
            int bestStart = 0;
            int bestLen = 1;
            for (int i = 0; i < elements.Length-1; i++)
            {
                if (elements[i] < elements[i+1])
                {
                    len++;
                }
                else
                {
                    if (len>bestLen)
                    {
                        bestLen = len;
                        bestStart=start;
                    }
                    len = 1;
                    start=i+1;
                }
            }
            if (len>bestLen)
            {
                bestLen = len;
                bestStart=start;
            }
            for (int i = bestStart; i < bestStart+bestLen; i++)
            {
                Console.Write(elements[i]+" ");
            }
        }
    }
}

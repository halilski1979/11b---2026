namespace _1._Algoritmichna
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] elements=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            if (n!=elements.Length)
            {
                Console.WriteLine("Invalid input");
                return;
            }

            int lenght = 1;
            int start= 0;

            int bestLenght = 1;
            int bestStart = 0;

            int sum = elements[0];
            int bestSum = elements[0];

            //2 5 6 1 4 5
            for (int i = 0; i < elements.Length - 1; i++)
            {
                if (elements[i] < elements[i+1])
                {
                    sum += elements[i + 1];
                    lenght++;
                }

                else
                {
                    if (lenght > bestLenght || lenght==bestLenght&&sum>bestSum)
                    {
                        bestLenght = lenght;
                        bestSum= sum;
                        bestStart = start;
                    }

                    lenght = 1;
                    start = i+1;
                    sum= elements[i+1];
                }
            }

            if (lenght>bestLenght || lenght==bestLenght&&sum>bestSum)
            {
                bestLenght = lenght;
                bestStart=start;
            }

            Console.WriteLine($"{bestLenght} {bestSum}");

            for (int i = bestStart; i < bestStart+bestLenght; i++)
            {
                Console.Write(elements[i] + " ");
            }
        }
    }
}

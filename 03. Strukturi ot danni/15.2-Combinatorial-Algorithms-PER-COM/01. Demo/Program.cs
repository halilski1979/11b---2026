namespace _01._Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Този метод с цикли работи чудесно за точно 3 елемента. 
            char[] elements = { 'A', 'B', 'C' };

                Console.WriteLine("Permutacii na  A, B , C:");
            int count = 0;
                // Първа позиция
                for (int i = 0; i < 3; i++)
                {
                    // Втора позиция
                    for (int j = 0; j < 3; j++)
                    {
                        // Трета позиция
                        for (int k = 0; k < 3; k++)
                        {
                            // Проверка дали елементите са различни (да няма повторения)
                            if (i != j && i != k && j != k)
                            {
                                Console.WriteLine($"{elements[i]} {elements[j]} {elements[k]}");
                            count++;
                            }
                        }
                    }
                }
            Console.WriteLine($"Broy permutacii: {count}");
        }
    }
}

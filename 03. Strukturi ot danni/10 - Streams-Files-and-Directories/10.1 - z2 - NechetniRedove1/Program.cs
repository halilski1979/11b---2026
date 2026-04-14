namespace _10._1___z2___NechetniRedove1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //За да запишеш резултата в нов файл (например output.txt), трябва да добавиш един
            //StreamWriter вътре или около твоя цикъл.

            string inputFilePath = "input.txt";
            string outputFilePath = "output.txt"; // Пътят към новия файл

            using (StreamReader reader = new StreamReader(inputFilePath))
            using (StreamWriter writer = new StreamWriter(outputFilePath)) // Отваряме файла за писане
            {
                int counter = 0;
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    // Проверяваме дали индексът на реда е нечетен (1, 3, 5...)
                    if (counter % 2 == 1)
                    {
                        writer.WriteLine(line); // Записваме реда във файла
                        Console.WriteLine(line); // По желание принтираме и в конзолата
                    }
                    counter++;
                }
            }
        }
    }
}

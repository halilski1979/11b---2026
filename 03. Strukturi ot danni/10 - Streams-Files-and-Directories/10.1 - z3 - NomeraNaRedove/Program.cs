namespace _10._1___z3___NomeraNaRedove
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която чете текстов файл (например input.txt) и добавя номера на редовете.
            //Резултатът трябва да се напише на друг текстов файл (например output.txt).

            string inputFilePath = "input.txt";
            string outputFilePath = "output.txt";

            // Отваряме StreamReader за четене и StreamWriter за запис
            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                using (StreamWriter writer = new StreamWriter(outputFilePath))
                {
                    int counter = 1; // Започваме от 1 за номерацията на редовете
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        // Форматираме реда: "1. Текст на реда"
                        string formattedLine = $"{counter}. {line}";

                        writer.WriteLine(formattedLine); // Записваме в изходния файл
                        Console.WriteLine(formattedLine); // Показваме резултата и в конзолата
                        counter++;

                    }
                }
            }
        }
    }
}

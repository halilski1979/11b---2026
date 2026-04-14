namespace _01._Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Намира броя на думите, брои броя на редовете
            string path = "input.txt";
            int wordCount = 0;
            int lineCount = 0;

            // Използваме 'using' директно върху StreamReader за по-чист код
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Разделяме реда на думи, като премахваме празните записи (например излишни интервали)
                    string[] words = line.Split(new char[] { ' ','.',':','!','?', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    wordCount += words.Length;
                    lineCount++;
                    // Опционално: принтираме реда
                    Console.WriteLine(line);
                }
            }

            Console.WriteLine($"\nObsht broy dumi: {wordCount}");
            Console.WriteLine($"LineCount:{lineCount}");
        }
    }
}

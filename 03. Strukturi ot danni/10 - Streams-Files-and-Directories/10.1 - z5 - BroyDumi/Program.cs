using System.Text;

namespace _10._1___z5___BroyDumi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Уверете се, че тези файлове съществуват в посочената папка!
            string wordsFilePath = "words.txt";
            string textFilePath = "text.txt";
            string outputFilePath = "output.txt";

            CalculateWordCounts(wordsFilePath, textFilePath, outputFilePath);
           
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            if (!File.Exists(wordsFilePath) || !File.Exists(textFilePath))
            {
                Console.WriteLine("Error: Files are not found!");
                return;
            }

            var wordCounts = new Dictionary<string, int>();

            // 1. Четем думите, които търсим
            using (StreamReader wordsReader = new StreamReader(wordsFilePath))
            {
                string line;
                while ((line = wordsReader.ReadLine()) != null)
                {
                    string[] words = line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var word in words)
                    {
                        if (!wordCounts.ContainsKey(word)) wordCounts[word] = 0;
                    }
                }
            }

            // 2. Броим срещанията в текста
            using (StreamReader textReader = new StreamReader(textFilePath))
            {
                string line;
                char[] separators = { ' ', '.', ',', '!', '?', '-', ':', ';', '\t', '\r', '\n' };
                while ((line = textReader.ReadLine()) != null)
                {
                    string[] wordsInLine = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var word in wordsInLine)
                    {
                        if (wordCounts.ContainsKey(word)) wordCounts[word]++;
                    }
                }
            }

            // 3. Подготвяме изхода със StringBuilder
            StringBuilder sb = new StringBuilder();
            var sortedCounts = wordCounts.OrderByDescending(x => x.Value);

            foreach (var pair in sortedCounts)
            {
                string resultLine = $"{pair.Key} - {pair.Value}";
                sb.AppendLine(resultLine);
                Console.WriteLine(resultLine); // ТОВА ЩЕ ОТПЕЧАТА РЕЗУЛТАТА И В КОНЗОЛАТА
            }

            // 4. Записваме във файла
            File.WriteAllText(outputFilePath, sb.ToString());
        }
    }
}

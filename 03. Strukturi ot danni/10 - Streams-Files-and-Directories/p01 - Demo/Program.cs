namespace p01___Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "input.txt";
            StreamReader rd = new StreamReader(path);

            int wordCount = 0;
            int lineCount = 0;

            using (rd)
            {
                string line;
                while ((line = rd.ReadLine()) != null)
                {
                   string[] words= line.Split(new char[] {' ',',','.','!','?'},StringSplitOptions.RemoveEmptyEntries);
                    wordCount += words.Length;
                    lineCount++;
                    Console.WriteLine(line);
                }
            }

            Console.WriteLine($"WordsCount: {wordCount}");
            Console.WriteLine($"LinesCount: {lineCount}");

        }
    }
}

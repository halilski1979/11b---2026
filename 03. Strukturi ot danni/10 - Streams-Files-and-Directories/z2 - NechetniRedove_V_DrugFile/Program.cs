namespace z2___NechetniRedove_V_DrugFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputPath = "input.txt";
            string outputPath = "output.txt";

            using (StreamReader reader = new StreamReader(inputPath))
            {
                using (StreamWriter writer = new StreamWriter(outputPath))
                {
                    int counter = 0;
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (counter % 2 == 1)
                        {
                            writer.WriteLine(line);
                            Console.WriteLine(line);
                        }
                        counter++;
                    }
                }
            }
           

        }
    }
}

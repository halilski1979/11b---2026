namespace z3___NomerNaRed_OutpitFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputFile = "input.txt";
            string outputFile = "output.txt";

            using (StreamReader reader=new StreamReader(inputFile))
            {
                using (StreamWriter writer = new StreamWriter(outputFile))
                {
                    int counter = 1;
                    string line;

                    while ((line=reader.ReadLine())!=null)
                    {
                        string formateLine = $"{counter}.{line}";                        
                        writer.WriteLine(formateLine);
                        Console.WriteLine(formateLine);
                        counter++;
                    }
                }
            }
        }
    }
}

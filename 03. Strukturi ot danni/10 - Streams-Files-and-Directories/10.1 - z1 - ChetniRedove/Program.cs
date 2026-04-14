using System.Text;

namespace _10._1___z1___ChetniRedove
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputFilePath = "input.txt"; // Увери се, че файлът е в bin папката
                                                
            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                int counter = 0;
                string line;

                // Четем, докато има редове
                while ((line = reader.ReadLine()) != null)
                {
                    // Проверяваме дали редът е четен (0, 2, 4...)
                    if (counter % 2 == 0)
                    {
                        Console.WriteLine(line);
                    }
                    counter++; 
                }
            }

        }
    }
}

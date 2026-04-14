using System.Text;

namespace _00._Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "input.txt"; // Sloji fajla v bin papkata
            StreamReader reader = new StreamReader(path);

            using (reader)
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

        }
    }
}

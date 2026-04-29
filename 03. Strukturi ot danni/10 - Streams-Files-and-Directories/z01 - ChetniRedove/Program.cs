namespace z01___ChetniRedove
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "input.txt";
            StreamReader sr = new StreamReader(path);


            using (sr)
            {
                int counter = 0;
                string line;
                while ((line = sr.ReadLine()) != null)
                {
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

namespace _01._Zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input=Console.ReadLine().Split(' ').ToArray();
            foreach (var line in input)
            {
                for (int i = 0; i < line.Length; i++)
                {
                    Console.Write(line);
                }
            
            }
        }
    }
}

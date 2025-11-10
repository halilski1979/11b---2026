namespace _12._Print_StartGlavniBukvi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>
        {
            "Hello",
            "world",
            "Apple",
            "banana",
            "Tree",
            "car"
        };

            PrintStringsStartingWithCapital(words);
        }

        static void PrintStringsStartingWithCapital(List<string> strings)
        {
            foreach (string s in strings)
            {
                if (!string.IsNullOrEmpty(s) && char.IsUpper(s[0])) // Проверява дали първият символ е главна буква
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}

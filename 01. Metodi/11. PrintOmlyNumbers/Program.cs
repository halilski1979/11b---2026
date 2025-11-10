namespace _11._PrintOmlyNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var words=Console.ReadLine().Split(' ').ToList();

            PrintOnlyNumericStrings(words);
        }
        

        static void PrintOnlyNumericStrings(List<string> strings)
        {
            foreach (string s in strings)
            {
                bool allDigits = true;                

                foreach (char c in s)
                {
                    if (!char.IsDigit(c))
                    {
                        allDigits = false;
                        break;
                    }
                }

                if (allDigits)
                {
                    Console.WriteLine(s);
                }
            }
        }

    }
}

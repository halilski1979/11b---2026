namespace _06._1___z5___CodeOfCezar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = "";

            foreach (char ch in input)
            {
                char encryptedChar = (char)(ch + 3);
                result += encryptedChar;
            }

            Console.WriteLine(result);
        }
    }
}

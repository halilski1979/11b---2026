namespace _04._DemoCHar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch = ' ';

            Console.WriteLine(char.IsLetter(ch));
            Console.WriteLine(char.IsUpper(ch));
            Console.WriteLine(char.IsPunctuation(ch));
            Console.WriteLine(char.IsWhiteSpace(ch));
        }
    }
}

namespace _02.Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruits = "banana, apple, kiwi, banana, apple";

            Console.WriteLine(fruits.IndexOf("ana"));
            Console.WriteLine(fruits.LastIndexOf("coca"));
            Console.WriteLine(fruits.Contains("ivi"));

            Console.WriteLine("========");
            string text = "My name is John";
            string extractedWord = text.Substring(3, 4);
            Console.WriteLine(extractedWord);
            string extraWord=text.Substring(3);
            Console.WriteLine(extraWord);

        }
    }
}

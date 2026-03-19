namespace _06._1___z3___TextFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] bannedWords = Console.ReadLine().Split(", ");            
            string text = Console.ReadLine();

           
            foreach (string word in bannedWords)
            {              
                string replacement = new string('*', word.Length);               
                text = text.Replace(word, replacement);
            }
                       
            Console.WriteLine(text);
        }
    }
}

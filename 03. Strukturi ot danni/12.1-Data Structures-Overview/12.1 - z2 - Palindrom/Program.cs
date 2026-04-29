using System.Text;

namespace _12._1___z2___Palindrom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string originalWord = Console.ReadLine().ToLower();

            // 2. Създаваме стек и добавяме всички символи от думата в него
            Stack<char> charStack = new Stack<char>();
            foreach (char symbol in originalWord)
            {
                charStack.Push(symbol);
            }

           
            // 3. Създаваме обърнатата дума, като вадим символите от стека

            StringBuilder reversedWordBuilder = new StringBuilder();
            while (charStack.Count > 0)
            {
                // Методът Pop() взима най-горния (последния добавен) символ
                reversedWordBuilder.Append(charStack.Pop());
            }

            string reversedWord = reversedWordBuilder.ToString();

            // 4. Проверяваме дали оригиналната дума е равна на обърнатата
            if (originalWord == reversedWord)
            {
                Console.WriteLine($"The word {originalWord} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"The word {originalWord} is not a palindrome.");
            }
        }
    }
}

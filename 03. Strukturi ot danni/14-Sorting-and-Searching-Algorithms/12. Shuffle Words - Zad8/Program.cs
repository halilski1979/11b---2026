namespace _12._Shuffle_Words___Zad8
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            string[] words = Console.ReadLine().Split(' ');
            
            Random random = new Random();

            //Fisher-Yates Shuffle
            for (int i = words.Length - 1; i > 0; i--)
            {                
                int randomIndex = random.Next(0, i + 1);               
                string temp = words[i];
                words[i] = words[randomIndex];
                words[randomIndex] = temp;
            }

           
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}

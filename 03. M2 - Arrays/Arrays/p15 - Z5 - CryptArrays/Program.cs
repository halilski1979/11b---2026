namespace p15___Z5___CryptArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] words = new string[n];
            int[] encrypted = new int[n];

            for (int i = 0; i < n; i++)
            {
                words[i] = Console.ReadLine();
                encrypted[i] = Encrypt(words[i]);
            }

            
            Array.Sort(words, encrypted);

           
            foreach (int value in encrypted)
            {
                Console.WriteLine(value);
            }
        }

       public static int Encrypt(string word)
        {
            int sum = 0;
            int length = word.Length;
            string vowels = "aeiouAEIOU";

            foreach (char ch in word)
            {
                if (vowels.Contains(ch))
                {
                    sum += ch * length;
                }
                else
                {
                    sum += ch / length;
                }
            }

            return sum;
        }
    }
}

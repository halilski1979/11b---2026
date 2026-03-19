using System.Text;

namespace _06._1___z1___PovtarqneNaNiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Прочитане на думите от конзолата
            string[] words = Console.ReadLine().Split();
            
            StringBuilder result = new StringBuilder();
            
            foreach (string word in words)
            {
                
                int count = word.Length;               
                for (int i = 0; i < count; i++)
                {                   
                    result.Append(word);
                }
            }
                        
            Console.WriteLine(result.ToString());
        }
    }
}

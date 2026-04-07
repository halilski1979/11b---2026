namespace _00._Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {    
            string name = "Aleks";
            Console.WriteLine(name);
            
            char[] charArray=name.ToCharArray();

            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine($"name[{i}]={name[i]}");
            }
            Console.WriteLine();
            Console.WriteLine(name[0]);

            Console.WriteLine("===charArray===");
            charArray[0] = 'a';
            for (int i = 0; i < charArray.Length; i++)
            {
                Console.Write(charArray[i]);
            }

        }
    }
}

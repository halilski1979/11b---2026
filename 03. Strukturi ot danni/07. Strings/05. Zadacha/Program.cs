namespace _05._Zadacha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var zabrDumi = Console.ReadLine().Split(", ").ToList();

            string text= Console.ReadLine();

            foreach (var item in zabrDumi)
            {                
                    text=text.Replace(item,new string('*', item.Length));                
            }

            Console.WriteLine();
        }
    }
}

namespace _11._LinearSearch2___WithClass_Zad6
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int[] array = Console.ReadLine()
                                 .Split(' ')
                                 .Select(int.Parse)
                                 .ToArray();

            
            int key = int.Parse(Console.ReadLine());

            
            int result = BinarySearch.IndexOf(array, key);
            Console.WriteLine(result);
        }
    }
}

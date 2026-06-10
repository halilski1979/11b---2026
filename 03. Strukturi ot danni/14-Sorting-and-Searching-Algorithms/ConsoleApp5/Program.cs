namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(BinarySearch.IndexOf(nums, num)); 
        }
    }
}

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int[] mas=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
           int num=int.Parse(Console.ReadLine());

            Console.WriteLine(LinearSearch(mas, num));

        }

        public static int LinearSearch(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]==target)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}

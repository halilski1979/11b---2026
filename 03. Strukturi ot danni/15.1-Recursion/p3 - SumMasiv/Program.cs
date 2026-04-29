namespace p3___SumMasiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine(Sum(num, 2));
        }

        public static int Sum(int[] arr, int index)
        {
            if (index == arr.Length - 1)
            {
                return arr[index];
            }

            return arr[index]+Sum(arr, index+1);
        }
    }
}

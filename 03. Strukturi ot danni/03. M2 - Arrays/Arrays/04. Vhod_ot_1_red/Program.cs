namespace _04._Vhod_ot_1_red
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //Console.WriteLine(string.Join(" - ",num));

            for (int i = num.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(num[i]);
            }
        }
    }
}

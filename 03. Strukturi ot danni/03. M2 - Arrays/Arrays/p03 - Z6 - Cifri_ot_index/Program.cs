namespace p03___Z6___Cifri_ot_index
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                int number = i;

                while (number > 0)
                {
                    sum += number % 10;
                    number /= 10;
                }

                arr[i] = sum;
            }

            foreach (int element in arr)
            {
                Console.WriteLine(element);
            }
        }
    }
}

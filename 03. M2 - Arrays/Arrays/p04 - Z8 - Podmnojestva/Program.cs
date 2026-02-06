namespace p04___Z8___Podmnojestva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

            int[] secondArray = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            bool isSubset = true;

            foreach (var item in secondArray)
            {
                //проверява дали всички елементи от
                //втория масив се съдържат в първия масив.
                if (!firstArray.Contains(item))
                {
                    isSubset = false;
                    break;
                }
            }

            if (isSubset)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}

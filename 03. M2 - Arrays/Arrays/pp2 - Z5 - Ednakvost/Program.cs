namespace pp2___Z5___Ednakvost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine()
             .Split(' ')
             .Select(int.Parse)
             .ToArray();

            int[] secondArray = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            bool areEqual = true;

            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    areEqual = false;
                    break;
                }
            }

            if (areEqual)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}

namespace _11._LinearSearch___Zad6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                             .Split(' ')
                             .Select(int.Parse)
                             .ToArray();

            
            int targetValue = int.Parse(Console.ReadLine());

            int result = LinearSearch(array, targetValue);
            Console.WriteLine(result);
        }

       
        
        static int LinearSearch(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                {
                    return i; 
                }
            }
            return -1; 
        }
    }
}

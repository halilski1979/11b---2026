namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int tursenoChislo = int.Parse(Console.ReadLine());

            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                int mid = (right + left) / 2;

                if (nums[mid] == tursenoChislo)
                {
                    Console.WriteLine(mid);
                    return;
                }

                if (tursenoChislo > nums[mid])
                {
                    left = mid + 1;
                }

                else
                {
                    right = mid - 1;
                }
            }
            Console.WriteLine(-1);
        }
    }
}

namespace _02._BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 3, 4, 2, 5, 6 };

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 1; j < nums.Length - i; j++)
                {
                    if (nums[j - 1] > nums[j])
                        Swap(nums, j - 1, j);
                }
            }

            Console.WriteLine(string.Join(" ", nums));

        }

        static void Swap(int[] nums, int index1, int index2)
        {
            int oldNum = nums[index1];
            nums[index1] = nums[index2];
            nums[index2] = oldNum;
        }
    }
}

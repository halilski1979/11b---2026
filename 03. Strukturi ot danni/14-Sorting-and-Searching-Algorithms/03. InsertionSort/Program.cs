namespace _03._InsertionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 3, 4, 2, 5, 6 };

            for (int startIndex = 1; startIndex < nums.Length; startIndex++)
            {
                int currIndex = startIndex;
                while (currIndex > 0 && nums[currIndex] < nums[currIndex - 1])
                {
                    Swap(nums, currIndex, currIndex - 1);
                    currIndex--;
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

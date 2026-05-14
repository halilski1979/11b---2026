namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {3,4,5,1,2,5,7,11,2 };

            Array.Sort(nums);
            nums=nums.OrderBy(x => x).ToArray();


            for (int i = 0; i < nums.Length; i++)
            {
                int currentIndex = i;
                while (currentIndex > 0 && nums[currentIndex] < nums[currentIndex-1])
                {
                    Swap(nums,currentIndex,currentIndex-1);
                    currentIndex--;
                }
            }

            Console.WriteLine(string.Join(" ",nums));
        }

        public static void Swap(int[] numbers, int index1, int index2)
        {
            int oldNum= numbers[index1];
            numbers[index1] = numbers[index2];
            numbers[index2] = oldNum;
        }
    }
}

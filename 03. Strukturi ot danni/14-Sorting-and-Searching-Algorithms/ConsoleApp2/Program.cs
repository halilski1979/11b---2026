namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bubble Sort

            int[] nums = {3,5,1,4,6,9,2,5 };

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 1; j < nums.Length; j++)
                {
                    if (nums[j - 1] > nums[j])
                    {
                        Swap(nums,j-1,j);
                    }
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

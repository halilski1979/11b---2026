namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {2,4,3,12,4,6,7,1};

            for (int i = 0; i < nums.Length; i++)
            {
                int posMin = i;
                for (int next= i+1; next < nums.Length; next++)
                {
                    if (nums[next] < nums[posMin])
                    {
                        posMin = next;
                    }
                }
                if (posMin!=i)
                {
                    Swap(nums,posMin,i);
                }
            }

            Console.WriteLine(string.Join(" ",nums));
        }

        public static void Swap(int[] numbers, int index1, int index2)
        {
            int m= numbers[index1];
            numbers[index1] = numbers[index2];
            numbers[index2] = m;
        }

    }
}

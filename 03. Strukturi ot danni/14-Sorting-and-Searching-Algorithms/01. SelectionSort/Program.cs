namespace _01._SelectionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 3, 4, 2, 5, 6 };

            for (int i = 0; i < nums.Length - 1; i++)
            {
                // posМin е позицията от min, зададена на сегашния индекс от масив
                int posМin = i;

                for (int next = i + 1; next < nums.Length; next++)
                    if (nums[next] < nums[posМin])
                        posМin = next;                
                if (posМin != i)
                    Swap(nums, posМin, i);
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

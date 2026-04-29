namespace _15._1___1___Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Създайте рекурсивен метод, който: 1.Чете масив от числа от конзолата 2.Намира сумата на всички числа              

            var num = new int[5] { 1, 2, 3, 4, 5 };

            Console.WriteLine(Sum(num,1)); 
        }

        static int Sum(int[] array, int index) //Намира сумата след index, включително
        {
            if (index == array.Length - 1)
            {
                return array[index];
            }

            return array[index] + Sum(array, index + 1);
        }
    }
}

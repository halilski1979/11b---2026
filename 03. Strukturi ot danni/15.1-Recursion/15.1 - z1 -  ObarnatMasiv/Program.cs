namespace _15._1___z1____ObarnatMasiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Четем масива от конзолата
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            // Извикваме рекурсивния метод, започвайки от индекс 0
            PrintReversed(array, 2);
        }

        static void PrintReversed(int[] array, int index)
        {           
            if (index > array.Length - 1)
            {
                return;
            }
            
            PrintReversed(array, index + 1);            
            Console.Write(array[index] + " ");
        }
    }
}

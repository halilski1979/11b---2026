namespace _4._1___z4_____SumElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Четем размерите на матрицата
            string[] dimensions = Console.ReadLine().Split(", ");
            int rows = int.Parse(dimensions[0]);
            int cols = int.Parse(dimensions[1]);

            int[,] matrix = new int[rows, cols];
            int sum = 0;

            // Четем елементите на матрицата
            for (int i = 0; i < rows; i++)
            {
                string[] input = Console.ReadLine().Split(", ");

                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = int.Parse(input[j]);
                    sum += matrix[i, j];
                }
            }

            // Отпечатване на резултата
            Console.WriteLine($"Rows: {rows}");
            Console.WriteLine($"Columns: {cols}");
            Console.WriteLine($"Sum of elements: {sum}");
        }
    }
}

namespace _4._1___z5_____SumColumnsMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Четем размерите
            string[] dimensions = Console.ReadLine().Split(", ");
            int rows = int.Parse(dimensions[0]);
            int cols = int.Parse(dimensions[1]);

            int[,] matrix = new int[rows, cols];

            // Четем матрицата
            for (int i = 0; i < rows; i++)
            {
                string[] input = Console.ReadLine().Split(" ");

                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = int.Parse(input[j]);
                }
            }

            // Изчисляваме и отпечатваме сумата на всяка колона
            for (int j = 0; j < cols; j++)
            {
                int columnSum = 0;

                for (int i = 0; i < rows; i++)
                {
                    columnSum += matrix[i, j];
                }

                Console.WriteLine(columnSum);
            }
        }
    }
}

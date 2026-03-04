namespace _4._1___z3_____RazlikaDiagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];

            FillTheMatrix(matrix);

            int primarySum = GetsPrimarySum(matrix);
            int secondarySum = GetsSecondarySum(matrix);

            int difference = Math.Abs(primarySum - secondarySum);

            Console.WriteLine(difference);
        }

        static void FillTheMatrix(int[,] matrix)
        {
            int size = matrix.GetLength(0);

            for (int i = 0; i < size; i++)
            {
                string[] input = Console.ReadLine().Split();

                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = int.Parse(input[j]);
                }
            }
        }

        static int GetsPrimarySum(int[,] matrix)
        {
            int sum = 0;
            int size = matrix.GetLength(0);

            for (int i = 0; i < size; i++)
            {
                sum += matrix[i, i];
            }

            return sum;
        }

        static int GetsSecondarySum(int[,] matrix)
        {
            int sum = 0;
            int size = matrix.GetLength(0);

            for (int i = 0; i < size; i++)
            {
                sum += matrix[i, size - 1 - i];
            }

            return sum;
        }
    }
}

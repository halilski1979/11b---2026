namespace _00._Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] masiv = new int[10];

            int[,] matrix=new int[3,3];

            //GetLenght(0)  - Броят на редовете
            
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"A[{i},{j}]=");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }          

            Console.WriteLine($"for");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i,j]} ");
                }
                Console.WriteLine();
            }

            int s = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i%2!=0)
                    {
                        s += matrix[i, j];
                    }                   
                }
                Console.WriteLine($"SumRed[{i}]: {s}");
                s = 0;
            }


            int s1 = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i==j)
                    {
                        s1 += matrix[i, j];
                    }
                }
            }
            Console.WriteLine($"First: {s1}");

            int s2 = 0;
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                s2 += matrix[j, j];
            }
            Console.WriteLine(s2);
            //SumVtori Diagonal   

            int sum = 0;
            for (int j = 0; j < matrix.GetLength(0);j++)
            {
                sum = sum + (matrix[j,matrix.GetLength(0)-1-j]);
            }
            Console.WriteLine($"Secondary: {sum}");



        }
    }
}

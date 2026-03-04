namespace z01___SumMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int n = int.Parse(Console.ReadLine());            
            int[,] matrix = new int[n, n];
            int sum = 0; 

            // Попълване на матрицата
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {                    
                    matrix[i, j] = int.Parse(Console.ReadLine());                   
                    sum += matrix[i, j];
                }
            }

            Console.WriteLine("===========================================");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {                    
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine(); 
            }            
            Console.WriteLine($"Sum: {sum}");
        }
    }
}

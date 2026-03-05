namespace _00._Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] B = { 2, 3, 4, 11, 15 };

            int[,] A = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } ,{0,3,3,4 } };

            for (int j = 0; j < B.Length; j++)
            {
                Console.Write($"B[{j}]={B[j]} ");
            }

           
            Console.WriteLine();
            Console.WriteLine();
            // Обхождаме редовете на двумерния масив A
            for (int i = 0; i < A.GetLength(0); i++)
            {
                // Обхождаме колоните на текущия ред
                for (int j = 0; j < A.GetLength(1); j++)
                {                    
                    Console.Write($"A[{i},{j}]={A[i, j]} ");
                }                
                Console.WriteLine();
            }
        }
    }
}

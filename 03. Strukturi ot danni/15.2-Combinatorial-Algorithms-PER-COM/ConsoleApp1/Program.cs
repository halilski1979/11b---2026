namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] a = { 'a', 'b', 'c' };
            int counter = 0;

            for (int i = 0; i < a.Length; i++) 
            {
                for (int j = 0; j < a.Length; j++)
                {
                    for (int k = 0; k < a.Length; k++)
                    {
                        //if (i != j && j != k && k != i)
                        {
                            counter++;
                            Console.WriteLine($"{a[i]}  {a[j]} {a[k]}");                            
                        }
                        
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine(counter);
        }
    }
}

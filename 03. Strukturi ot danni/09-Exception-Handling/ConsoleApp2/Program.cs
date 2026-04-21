namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("A=");
                int a = int.Parse(Console.ReadLine());

                Console.Write("B=");
                int b = int.Parse(Console.ReadLine());

                int result = a / b;
                Console.WriteLine(result);
            }
                 
            catch (Exception ex)
            {
                Console.WriteLine("Neshto drugo se obarka!"+ex.Message);
            }
            finally
            {
                Console.WriteLine("Programata zavarshi uspeshno!");
            }
        }
    }
}

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            int res;
            
            Console.WriteLine("==============");
            Console.Write("Enter number: ");
            while (!int.TryParse(Console.ReadLine(), out res))
            {
                Console.WriteLine("Invallid number!");
                Console.WriteLine("Try again!");
                Console.Write("Enter number: ");
            }
            Console.WriteLine($"Our number is: {res}");
        }
    }
}

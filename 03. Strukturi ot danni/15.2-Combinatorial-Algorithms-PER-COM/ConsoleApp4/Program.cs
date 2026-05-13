namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
				int chislo = int.Parse(Console.ReadLine());
				int d = chislo / 10;
				int p= chislo % 10;
				if (chislo % d == 0 && chislo % p == 0)
				{
					Console.WriteLine("Yes!");
				}
				else
				{
                    Console.WriteLine("No!");
				}
			}
			catch (Exception)
			{
                Console.WriteLine("Something went wrong!");
				
			}
        }
    }
}

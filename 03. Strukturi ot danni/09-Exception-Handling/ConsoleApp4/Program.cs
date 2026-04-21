namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
		{
			try
			{
				double chislo = double.Parse(Console.ReadLine());
				if (chislo < 0)
				{
					throw new ArgumentException("Error. Otricatelno chislo!");
				}

				double koren = Math.Sqrt(chislo);
				Console.WriteLine($"{koren:f2}");

			}
			catch (Exception e)
			{
				Console.WriteLine("Invalid number!" +e.Message);
			}
			finally
			{
                Console.WriteLine("Good bye!");
			}
		}
	}
}

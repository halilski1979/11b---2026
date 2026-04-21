namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
		{
			try
			{
				Console.Write("Vavdete godini: ");
				int age = int.Parse(Console.ReadLine());

				if (age < 0 || age > 120)
				{
					throw new ArgumentException("Nerealni godini!");
				}
				if (age < 18)
				{
					throw new ArgumentException("Prekaleno si malak");
				}
				Console.WriteLine("Mojesh da zapochnesh kursove za shofyor!");
			}


			catch (FormatException)
			{
				Console.WriteLine("Napishi cqlo chislo");
			}
			catch (ArgumentException ex)
			{
				Console.WriteLine("Problem s dannite. " + ex.Message);
			}
			catch (Exception ex)
			{
                Console.WriteLine("Otkazano: " + ex.Message);
			}
			finally
			{
                Console.WriteLine("Proverkata zavarshi!");
			}

            Console.WriteLine("==============");
            Console.Write("Koq kategoriq iskash");
			string kat=Console.ReadLine();
		}
	}
}

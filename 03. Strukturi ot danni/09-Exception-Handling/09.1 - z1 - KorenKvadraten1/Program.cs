namespace _09._1___z1___KorenKvadraten1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Vavedi chislo: ");
                double chislo = double.Parse(Console.ReadLine());

                if (chislo < 0)
                {
                    // Rachno hvashatme otricatelnite
                    throw new ArgumentOutOfRangeException();
                }

                Console.WriteLine(Math.Sqrt(chislo));
            }
            catch (FormatException)
            {
                // Tuk vliza samo ako potrebitelyat napishi "abc" vmesto "123"
                Console.WriteLine("Greshka: Napisal si bukvi, a trqbva chislo!");
            }
            catch (ArgumentOutOfRangeException)
            {
                // Tuk vliza samo ako chisloto e otricatelno
                Console.WriteLine("Invalid number. (trqbva da e nad nula)");
            }
            catch (Exception)
            {
                // Tova e "bash bashtata" - hvashta vsičko drugo ostanalo
                Console.WriteLine("Nqkakva druga greshka stana...");
            }
            finally
            {
                Console.WriteLine("Good bye.");
            }
        }
    }
}

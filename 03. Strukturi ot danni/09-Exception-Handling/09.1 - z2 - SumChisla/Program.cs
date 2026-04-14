namespace _09._1___z2___SumChisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Chetem vhodnite danni kato nizove
           var elementi = Console.ReadLine().Split(' ').ToList();

            // 2. Promenliva za sumata
            int suma = 0;

            // 3. Obhojdane s foreach
            foreach (var element in elementi)
            {
                try
                {
                    // Opitvame se da parsnem i dobavim kym sumata
                    int chislo = int.Parse(element);
                    suma += chislo;
                }
                catch (FormatException)
                {
                    // Greshka pri format (napr. "invalid" ili "3.4")
                    Console.WriteLine($"The element '{element}' is in wrong format!");
                }
                catch (OverflowException)
                {
                    // Greshka pri obhvata na int (prekaleno golqmo/malko)
                    Console.WriteLine($"The element '{element}' is out of range!");
                }
                finally
                {
                    // Tova se pechata vinagi sled vseki element
                    Console.WriteLine($"Element '{element}' processed - current sum: {suma}");
                }
            }

            // Finalen rezultat
            Console.WriteLine($"The total sum of all integers is: {suma}");
        }
    }
}

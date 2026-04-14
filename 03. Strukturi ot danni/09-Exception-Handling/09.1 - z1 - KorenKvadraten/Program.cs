namespace _09._1___z1___KorenKvadraten
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
                    // Izvhvarlyame greshka, ako chisloto e pod nula
                    throw new ArithmeticException();
                }

                double koren = Math.Sqrt(chislo);
                Console.WriteLine(koren);
            }
            catch (Exception)
            {
                // Prihvashta bukvi, prazni poleta ili otritsatelni chisla
                Console.WriteLine("Invalid number.");
            }
            finally
            {
                // Tova se izpalnyava vinagi na kraya
                Console.WriteLine("Good bye.");
            }
        }
    }
}

namespace _100._Vazrast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Vavedi godini: ");
                // 1. FormatException: Ako vavedesh "abc" vmesto "25"
                // 2. OverflowException: Ako vavedesh 999999999999999999999999
                int godini = int.Parse(Console.ReadLine());

                if (godini < 0)
                {
                    // 3. ArgumentOutOfRangeException: Nasha proverka za otricatelni
                    throw new ArgumentOutOfRangeException();
                }

                if (godini > 120)
                {
                    // 4. Custom greshka: Ako nqkoj se pravi na Metusalen
                    throw new Exception("Prekaleno star si za tozi svqt!");
                }

                Console.WriteLine($"Super, na {godini} godini si!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Greshka: Napishi chislo de, ne bukvi!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Greshka: Tozi broj e mega ogromen, ti ne si danyk liva!");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Greshka: Ne moje da si na minus godini, nerealno e!");
            }
            catch (Exception ex)
            {
                // Tuk vliza "Prekaleno star si..." ili vsi4ko drugo nepredvideno
                Console.WriteLine($"Greshka: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Good bye! (i jivi i zdravi)");
            }
        }
    }
}

namespace _00._Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Vavedi chislo A: ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Vavedi chislo B: ");
                int b = int.Parse(Console.ReadLine());

                int result = a / b;
                Console.WriteLine($"Rezultatat e: {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Greshka: Ne mojesh da delish na nula!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Greshka: Napishi cialo chislo, a ne bukvi.");
            }
            catch (Exception ex)
            {
                //Ако въведем число извън границите на int
                Console.WriteLine("Neshto drugo se oburka: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Programata zavurshi bez da zabiie.");
            }
        }
    }
}

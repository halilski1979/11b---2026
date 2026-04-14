using System.Drawing;

namespace _000._Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size: ");
            string input = Console.ReadLine();

            // Опитай се да превърнеш input в число. 
            // Резултатът отива в променливата 'size', а методът връща true или false.
            if (int.TryParse(input, out int size))
            {
                Console.WriteLine($"Uspeshno zadaden razmer: {size}");
            }
            else
            {
                Console.WriteLine("Invalid size! Molq, vavedi cqlo chislo.");
            }


            Console.WriteLine("=================================");
            int razmer;

            Console.Write("Vavedi razmer: ");

            // Dokato potrebitelyat ne vavedi validno chislo, cikalat prodaljava
            while (!int.TryParse(Console.ReadLine(), out razmer))
            {
                Console.WriteLine("Greshka! Invalid size! Dai pak.");
                Console.Write("Vavedi pak: ");
            }

            // Tuk veche imame validno chislo v 'razmer'
            Console.WriteLine($"Bravo, razmerat e: {razmer}");

            Console.WriteLine("=================================");


        }
    }
}

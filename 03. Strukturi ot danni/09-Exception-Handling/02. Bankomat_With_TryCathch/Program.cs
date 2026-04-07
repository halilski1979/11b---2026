namespace _02._Bankomat_With_TryCathch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int balans = 100;

            try
            {
                
                Console.Write("Kolko pari iskash: ");
                int suma = int.Parse(Console.ReadLine());

                if (suma > balans)
                {
                    // ТУК СПИРАМЕ ВСИЧКО! 
                    // Програмата „скача“ директно в catch и НЕ докосва баланса.
                    throw new Exception("Niamash dostatuchno pari v kartata!");
                }

                // Този код ще се изпълни САМО ако имаме достатъчно пари
                balans = balans - suma;
                Console.WriteLine("Uspeshno teglene! Vzemi si parite.");
                Console.WriteLine("Ostavasht balans: " + balans);
            }
            catch (Exception ex)
            {
                // Тук улавяме грешката и я показваме на потребителя
                Console.WriteLine("Greshka: " + ex.Message);
            }

            Console.WriteLine("Bankomatat e gotov za sledvashtata operacia.");
        }
    }
    
}

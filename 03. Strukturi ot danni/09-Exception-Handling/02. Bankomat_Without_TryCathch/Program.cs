namespace _02._Bankomat_Without_TryCathch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int balans = 100;
            int suma = 150;

            if (suma > balans)
            {
                Console.WriteLine("Niamash dostatuchno pari!");
            }

            // Програмата продължава надолу, въпреки че нямаме пари!
            balans = balans - suma;
            Console.WriteLine("Vzemi si parite: " + suma);
            Console.WriteLine("Nov balans: " + balans); // Ще изпише -50 лева! Банката е на загуба.
        }
    }
}

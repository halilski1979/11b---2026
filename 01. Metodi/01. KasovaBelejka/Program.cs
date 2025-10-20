namespace _01._KasovaBelejka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintAll();
        }

        public static void Header()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }

        public static void Middle()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        public static void Footer()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("IT KARIERA");
        }

        public static void PrintAll()
        {
            Header();
            Middle();
            Footer();
        }
    }
}

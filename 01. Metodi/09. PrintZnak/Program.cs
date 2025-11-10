namespace _09._PrintZnak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Znak();
        }

        public static void Znak()
        {
            int a = int.Parse(Console.ReadLine());

            if (a > 0)
            {
                Console.WriteLine("Polojitelno");
            }
            else if (a < 0)
            {
                Console.WriteLine("Otricatelno");
            }
            else if (a == 0)
            {
                Console.WriteLine("Chisloto e 0");
            }
        }
    }
}

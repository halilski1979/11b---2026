namespace _15._1___2___Demo___Factoriel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Създайте рекурсивен метод, който: 1.Прочита числото n от конзолата  2. Изчислява n!
            Console.WriteLine(GetFactorial(4));
        }

        public static long GetFactorial(int num)
        {
            if (num == 0)
                return 1;

            return num * GetFactorial(num - 1);
        }


    }
}

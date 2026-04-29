namespace _15._1___3___Demo___PechatFIGURA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишете рекурсивен метод, който рисува следната фигура

            Draw(5);
        }

        static void Draw(int n)
        {
            // 1. Дъно на рекурсията
            if (n <= 0)
            {
                return;
            }

            // 2. Преди рекурсията: Рисуваме звездичките (намаляващи)
            Console.WriteLine(new string('*', n));

            // 3. Рекурсивно извикване
            Draw(n - 1);

            // 4. След рекурсията: Рисуваме диезите (увеличаващи се)
            Console.WriteLine(new string('#', n));
        }
    }
}

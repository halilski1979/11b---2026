namespace P15_Chasove
{
    internal class Program
    {
        //Създайте метод FormatTime(int seconds), който преобразува секунди в формат HH:MM:SS.
        static void Main(string[] args)
        {
            int vuvedi = int.Parse(Console.ReadLine());
            FormatTime(vuvedi);
        }

        public static void FormatTime(int vuvedi)
        {
            var chasove = vuvedi / 3600;
            var minuti = (vuvedi %  3600) / 60;
            var sekundi = vuvedi % 60;

            Console.WriteLine($"{chasove:d2} : {minuti:d2} : {sekundi:d2}");
        }
    }
}

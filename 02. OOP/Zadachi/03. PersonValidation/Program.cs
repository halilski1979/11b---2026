using System.Globalization;

namespace _03._PersonValidation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> list = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                var cmd = Console.ReadLine().Split(' ').ToList();

                string ime = cmd[0];
                string familiq = cmd[1];
                int godini = int.Parse(cmd[2]);
                double zaplata = double.Parse(cmd[3]);

                Person p = new Person(ime, familiq, godini, zaplata);
                list.Add(p);
            }

            double percent = double.Parse(Console.ReadLine());
            foreach (var item in list)
            {
                item.IncreaseSalary(percent);
            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}

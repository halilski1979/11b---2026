namespace _100_5._1_zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ').ToList();

                string name= input[0];
                double grade=double.Parse(input[1]);

                if (!students.ContainsKey(name))
                {
                    students[name] = new List<double>();
                    students[name].Add(grade);
                }
                else
                {
                    students[name].Add(grade);
                }
            }

            foreach (var item in students)
            {
                string grades = string.Join(" ", item.Value.Select(x => x.ToString("F2")));
                double avg = item.Value.Average();
                Console.WriteLine($"{item.Key} -> {grades} (avg: {avg:f2})");
            }
        }
    }
}

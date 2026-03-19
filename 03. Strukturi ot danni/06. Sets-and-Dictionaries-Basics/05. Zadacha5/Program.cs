namespace _05._Zadacha5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,List<double>> students= new Dictionary<string,List<double>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var cmd = Console.ReadLine().Split(' ').ToList();
                string name= cmd[0];
                double grade= double.Parse(cmd[1]);

                if (students.ContainsKey(name))
                {
                    students[name].Add(grade);
                }
                else
                {
                    students.Add(name, new List<double>());
                    students[name].Add(grade);
                }
            }

            foreach (var student in students)
            {
                students[]
                Console.WriteLine();
            }
        }
    }
}

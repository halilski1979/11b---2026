namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, int> studentGrades = new SortedDictionary<string, int>();
            studentGrades.Add("Ivan", 4);
            studentGrades.Add("Peter", 6);
            studentGrades.Add("Maria", 6);
            studentGrades.Add("George", 5);



            int peterGrade = studentGrades["Peter"];

            Console.WriteLine("Peter's grade: {0}", peterGrade); Console.WriteLine("Students and their grades:");
            foreach (var pair in studentGrades)
                Console.WriteLine("{0} --> {1}", pair.Key, pair.Value);

        }
    }
}

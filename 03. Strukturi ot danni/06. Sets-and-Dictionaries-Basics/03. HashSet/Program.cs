namespace _03._HashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Pesho");
            list.Add("Pesho");
            list.Add("Gosho");
            Console.WriteLine(string.Join(" ", list));
            Console.WriteLine(list.Count());

            list=list.Distinct().ToList();
            Console.WriteLine(string.Join(" ", list));

            Console.WriteLine();
            HashSet<string> set = new HashSet<string>();
            set.Add("Pesho");
            set.Add("Pesho");
            set.Add("Gosho");
            Console.WriteLine(string.Join(" ",set));
            Console.WriteLine(set.Count());

            Console.WriteLine(set.Contains("Gosho"));
            set.Remove("Gosho");
            Console.WriteLine(string.Join(" ", set));
            Console.WriteLine(set.Count());
        }
    }
}

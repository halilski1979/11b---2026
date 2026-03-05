namespace _03._HashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();
            set.Add("Pesho");
            set.Add("Pesho"); // Не го добавя отново
            set.Add("Gosho");

            Console.WriteLine(string.Join(", ", set)); // Pesho, Gosho


            Console.WriteLine(set.Contains("Georgi")); // false
            Console.WriteLine(set.Contains("Pesho")); // true
            set.Remove("Pesho");
            Console.WriteLine(set.Count); // 1


        }
    }
}

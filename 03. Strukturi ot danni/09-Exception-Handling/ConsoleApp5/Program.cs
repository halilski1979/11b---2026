namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var element = Console.ReadLine().Split(' ').ToList();
            int sum = 0;

            foreach (var item in element)
            {
                try
                {
                    int chislo = int.Parse(item);
                    sum += chislo;
                }
                catch (FormatException)
                {
                    Console.WriteLine($"The element {item} is not correct format");
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"The element {item} is out of range!");
                }
                finally
                {
                    Console.WriteLine($"Element '{item}' processed - current sum: {sum}");
                }
            }

            Console.WriteLine($"The total sum of all integers is: {sum}");
        }
    }
}

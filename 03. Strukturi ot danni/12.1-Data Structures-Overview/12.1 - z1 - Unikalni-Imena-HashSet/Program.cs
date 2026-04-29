namespace _12._1___z1___Unikalni_Imena_HashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var allNames = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            // Използваме HashSet с игнориране на малки/големи букви

            HashSet<string> uniqueNames = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            foreach (var name in allNames)
            {
                uniqueNames.Add(name);
            }

            // Тъй като HashSet НЕ е сортиран, трябва да го сортираме ръчно преди печат
            var sortedNames = uniqueNames.OrderBy(n => n, StringComparer.OrdinalIgnoreCase);

            foreach (var name in sortedNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}

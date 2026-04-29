namespace _12._1___z1___Unikalni_Imena
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            string[] allNames = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            // 2. Създаваме SortedSet с настройка за Case-Insensitive сравнение.
            // Това автоматично ще сортира имената по азбучен ред и ще пренебрегва малки/големи букви при проверка за уникалност.
            // ВАЖНО: При "Brian" и "brian", SortedSet ще запази само първия срещнат вариант ("Brian").

            SortedSet<string> uniqueNames = new SortedSet<string>(StringComparer.OrdinalIgnoreCase);

            // 3. Добавяме имената в множеството
            foreach (string name in allNames)
            {
                uniqueNames.Add(name);
            }

            // 4. Отпечатваме всяко име на нов ред
            foreach (string name in uniqueNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}

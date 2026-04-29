namespace _12._1___z3___ObedinenieMnojestva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Прочитаме двата списъка с числа и ги превръщаме в масиви от int
            int[] firstArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            // 2. Създаваме множества за всеки масив (това премахва повторенията вътре в тях)
            HashSet<int> firstSet = new HashSet<int>(firstArray);
            HashSet<int> secondSet = new HashSet<int>(secondArray);

            // 3. Създаваме трето множество за обединението
            HashSet<int> numsUnion = new HashSet<int>();

            // 4. Итерираме през първото множество и добавяме в обединението
            foreach (int num in firstSet)
            {
                numsUnion.Add(num);
            }

            // 5. Итерираме през второто множество и добавяме в обединението
            // HashSet автоматично ще пропусне числата, които вече са добавени от първото
            foreach (int num in secondSet)
            {
                numsUnion.Add(num);
            }

            // 6. Отпечатваме резултата, разделен с интервал
            Console.WriteLine(string.Join(" ", numsUnion));
        }
    }
}

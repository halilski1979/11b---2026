namespace _01._Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Стекът е структура от данни тип LIFO – Last In, First Out.
            //Това означава, че последният добавен елемент е първият, който се премахва.


            Stack<string> stack = new Stack<string>();

            //Push(item)	Добавя елемент в горната част на стека
            stack.Push("Parvi");
            stack.Push("Vtori");
            stack.Push("Treti");
            stack.Push("Chetvarti");
            stack.Push("Peti");

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            //Конвертиране стека в масив с ToArray() и в списък ToList()
            string[] masiv = stack.ToArray();
            List<string> spisak = stack.ToList();


            //Pop()	Премахва и връща най-горния елемент
            Console.WriteLine();
            Console.WriteLine("===Pop()===");
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());


            //Peek()	Връща най-горния елемент без да го премахва
            Console.WriteLine();
            Console.WriteLine("===Peek()===");
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Peek());

            //Count	Връща броя на елементите в стека
            Console.WriteLine();
            Console.WriteLine("===Count===");
            Console.WriteLine($"Broy elementi: {stack.Count}");


            //Clear()	Изтрива всички елементи от стека
            Console.WriteLine();
            Console.WriteLine("===Clear===");
            stack.Clear();
            Console.WriteLine($"Broy elementi: {stack.Count}");


            Console.WriteLine();
            foreach (var item in masiv)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            foreach (var item in spisak)
            {
                Console.WriteLine(item);
            }
        }
    }
}

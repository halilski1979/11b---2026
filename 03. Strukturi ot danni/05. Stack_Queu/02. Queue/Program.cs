namespace _02._Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Опашката е структура от данни тип FIFO – First In, First Out.
            //Това означава, че първият добавен елемент ще бъде и първият изваден.


            Queue<int> ints = new Queue<int>();


            //Enqueue()	Добавя елемент в края на опашката
            ints.Enqueue(1);
            ints.Enqueue(2);
            ints.Enqueue(3);
            ints.Enqueue(4);
            ints.Enqueue(5);
            ints.Enqueue(6);
            Console.WriteLine("============ Print Queue ==============");
            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("====================================");

            //Конвертиране в масив с ToArray() и в списък ToList()
            int[] masiv = ints.ToArray();
            List<int> list = ints.ToList();

            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            Console.WriteLine("===Dequeue===");

            //Dequeue()	Премахва и връща елемента най-отпред
            Console.WriteLine(ints.Dequeue());
            Console.WriteLine(ints.Dequeue());

            Console.WriteLine();
            Console.WriteLine("===Peek===");
            //Peek()	Връща елемента най-отпред, без да го маха
            Console.WriteLine(ints.Peek());

            Console.WriteLine();
            Console.WriteLine("===Count===");
            //Count	Брой на елементите в опашката
            Console.WriteLine($"Broy elementi v opashkata: {ints.Count()}");

            Console.WriteLine();
            Console.WriteLine("===Clear===");
            //Clear()	Изчиства всички елементи
            ints.Clear();
            Console.WriteLine($"Broy elementi v opashkata: {ints.Count()}");


            //Печат на масив
            Console.WriteLine();
            foreach (int i in masiv)
            {
                Console.WriteLine(i);
            }

            //Печат на списък
            Console.WriteLine();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}

namespace _3._1___z2___SumaOtSteck
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var stack = new Stack<int>(Console.ReadLine().Split(' ').Select(int.Parse));
           var command=Console.ReadLine().ToLower().Split(' ').ToList();

            while ((command[0] != "end"))
            {              

                if (command[0] == "add")
                {
                    int num1 = int.Parse(command[1]);
                    int num2 = int.Parse(command[2]);

                    stack.Push(num1);
                    stack.Push(num2);
                }
                else if (command[0] == "remove")
                {
                    int count = int.Parse(command[1]);
                    if (stack.Count >= count)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
                command = Console.ReadLine().ToLower().Split(' ').ToList();
            }
           
            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}

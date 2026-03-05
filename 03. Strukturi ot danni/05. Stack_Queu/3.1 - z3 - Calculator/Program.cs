namespace _3._1___z3___Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
           Stack<string> stack = new Stack<string>(Console.ReadLine().Split().Reverse());

            // Взимаме първото число от стека и го запазваме като начален резултат
            int result = int.Parse(stack.Pop());

            // Докато в стека има още елементи
            while (stack.Count > 0)
            {
                // Взимаме оператора (+ или -)
                string op = stack.Pop();

                // Взимаме следващото число
                int number = int.Parse(stack.Pop());

                // Проверяваме оператора и извършваме съответната операция
                if (op == "+")
                {
                    result += number; // събиране
                }
                else if (op == "-")
                {
                    result -= number; // изваждане
                }
            }

            // Отпечатваме крайния резултат
            Console.WriteLine(result);
        }
    }
}

namespace _00._Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            string number = Console.ReadLine();            
            string secondNumber = new string(number.Reverse().ToArray());
                        
            int a = int.Parse(secondNumber);
            int b = int.Parse(number);

            if (a == b)
            {
                Console.WriteLine("Palindrom");
            }
            else
            {
                Console.WriteLine("Ne e palindrom");
            }
        }
    }
}

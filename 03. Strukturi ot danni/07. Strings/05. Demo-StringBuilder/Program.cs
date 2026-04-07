using System.Text;

namespace _05._Demo_StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Hello, ");
            sb.Append("John! ");
            sb.AppendLine("I sent you an email.");
            sb.AppendLine("Bye for now!");
            Console.WriteLine(sb);

            

        }
    }
}

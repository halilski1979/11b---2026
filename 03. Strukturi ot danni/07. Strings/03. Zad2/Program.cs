namespace _03._Zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ").ToList();
            List<string> validUsers = new List<string>();

            foreach (var item in input)
            {
                bool validLenght=false;
                bool validSymbols = true;

                if (item.Length>=3 && item.Length<=16)
                {
                    validLenght = true;
                }

                foreach (char symbol in item)
                {
                    if (!(char.IsLetterOrDigit(symbol)||symbol=='-'||symbol=='_'))
                    {
                        validSymbols = false;
                        break;
                    } 
                }

                if (validLenght == true && validSymbols == true)
                {
                   validUsers.Add(item);
                }

               
            }

            foreach (var item in validUsers)
            {
                Console.WriteLine(item);
            }
        }
    }
}

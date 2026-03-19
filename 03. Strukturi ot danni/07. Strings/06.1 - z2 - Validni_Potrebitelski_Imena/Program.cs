namespace _06._1___z2___Validni_Potrebitelski_Imena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] input = Console.ReadLine().Split(", "); 
            
            List<string> validUsers = new List<string>();
            
            foreach (string username in input)
            {
                //Променливи за проверка
                bool validLength = false;
                bool validSymbols = true;

                //Проверка на дължината (3 до 16 символа)
                if (username.Length >= 3 && username.Length <= 16)
                {
                    validLength = true;
                }

                //Обхождане на всеки символ в името
                foreach (char symbol in username)
                {
                    //Проверка за разрешените символи: букви, цифри, '-' или '_'
                    if (!(char.IsLetterOrDigit(symbol) || symbol == '-' || symbol == '_'))
                    {
                        validSymbols = false;
                        break;
                    }
                }

                
                if (validLength && validSymbols)
                {
                    validUsers.Add(username);
                }
            }

            
            foreach (string user in validUsers)
            {
                Console.WriteLine(user);
            }
        }
    }
}

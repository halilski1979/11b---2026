namespace _09._1___z3___CorrectNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = 1;
            int end = 100;
            List<int> validNums = new List<int>();

            // Vartim, dokato ne saberem tochno 10 chisla
            while (validNums.Count < 10)
            {
                try
                {
                    int currentNumber = ReadNumber(start, end);
                    validNums.Add(currentNumber);
                }
                catch (Exception ex)
                {
                    // Pechatame saobshtenieto na greshkata (range ili format)
                    Console.WriteLine(ex.Message);
                }
            }

            // Otpechatvame rezultata, razdelen sys zapetaq i interval
            Console.WriteLine(string.Join(", ", validNums));
        }



        static int ReadNumber(int start, int end)
        {
            try
            {
                int number = int.Parse(Console.ReadLine());

                // Proverka za diapazona (izvan start...end)
                if (number <= start || number >= end)
                {
                    throw new ArgumentOutOfRangeException($"Your number is not in range ({start} - {end})");
                }

                return number;
            }
            catch (FormatException)
            {
                // Hvashatme tekst i go hvarlyame nanovo s novo saobshtenie
                throw new Exception("Invalid Number!");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                // Preprashtame range greshkata nagore
                throw ex;
            }
        }
    }
}
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            string destination = "Varna";
            int days = 5;
            double distance = 470;
            string transport = "train";
            double budget = 300;

            // Print travel information using string interpolation
            Console.WriteLine($"I am traveling to {destination} for {days} days. The distance is {distance} km, I will go by {transport} and my budget is {budget} lv.");
        }

    }
    
}

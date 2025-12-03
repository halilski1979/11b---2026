namespace _03.Human_Izpit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
          
            List<Human> humans = new List<Human>();
            
            for (int i = 0; i < n; i++)
            {
                Console.Write("First name: ");
                string ime = Console.ReadLine();

                Console.Write("Last name: ");
                string familiq = Console.ReadLine();

                Console.Write("Age: ");
                int godini = int.Parse(Console.ReadLine());

                Console.Write("Your choice[s - student] , [w - worker]: ");
                string choice = Console.ReadLine();

                if (choice == "w")
                {
                    Console.Write("Wage: ");
                    double wage = double.Parse(Console.ReadLine());

                    Console.Write("Hours worked: ");
                    int hours = int.Parse(Console.ReadLine());

                   Human w = new Worker(ime, familiq, godini, wage, hours);
                    humans.Add(w);
                }
                if (choice == "s")
                {
                    Console.Write("Grade: ");
                    double grade = double.Parse(Console.ReadLine());

                    Human s = new Student(ime, familiq, godini, grade);
                   humans.Add(s);
                }
            }

            for (int i = humans.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(humans[i]);
            }
        }
    }
}

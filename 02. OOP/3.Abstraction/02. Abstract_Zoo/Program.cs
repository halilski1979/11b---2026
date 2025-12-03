namespace _02._Abstract_Zoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Animal> animals = new List<Animal>();

            for (int i = 0; i < n; i++)
            {
                Console.Write("Name: ");
                string ime = Console.ReadLine();
                
                Console.Write("Age: ");
                int godini = int.Parse(Console.ReadLine());

                Console.Write("Animal: ");
                string jivotno = Console.ReadLine();


                if (jivotno == "lion")
                {
                    Animal l = new Lion(ime, godini, jivotno);
                    animals.Add(l);
                }
                if (jivotno == "parrot")
                {
                    Animal p = new Parrot(ime, godini, jivotno);
                    animals.Add(p);
                }
            }
            foreach (var item in animals)
            {
                Console.WriteLine(item.MakeSound()); 
            }
        }
    }
}

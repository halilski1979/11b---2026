namespace _02._AnimalKingdom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cmd = Console.ReadLine().Split(" ").ToList();
            List<Animal> animals = new List<Animal>();

            while (true)
            {
                if (cmd[0] == "END")
                {
                    break;
                }

                string name = cmd[0];
                int age = int.Parse(cmd[1]);

                if (name == "Cat")
                {
                    Animal c = new Cat (name, age);
                    animals.Add(c);
                    Console.WriteLine(c.MakeNoise());
                    Console.WriteLine(c.MakeTrick());
                }
                else if (name == "Dog")
                {
                    Animal d = new Dog(name, age);
                    animals.Add(d);
                    Console.WriteLine(d.MakeNoise());
                    Console.WriteLine(d.MakeTrick());
                }
                cmd = Console.ReadLine().Split(" ").ToList();
            }
             
        }
    }
}

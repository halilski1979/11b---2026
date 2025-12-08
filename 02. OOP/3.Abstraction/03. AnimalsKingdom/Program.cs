namespace _03._AnimalsKingdom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of animals: ");
            int n=int.Parse(Console.ReadLine());

            List<Animal> animals = new List<Animal>();


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter details for animal {i+1}:");
                Console.Write("Name: "); 
                string name=Console.ReadLine();

                Console.Write("Age: ");
                int age=int.Parse(Console.ReadLine());

                Console.Write("Weight: ");
                double weight=double.Parse(Console.ReadLine());

                Console.Write("Habitat: ");
                string habitat=Console.ReadLine();

                Console.Write("Enter the type of animal (Lion, Parrot, Elephant):");
                string type=Console.ReadLine();

                Animal animal = null;

                if (type=="lion")
                {
                   animal = new Lion(name,age,type,weight,habitat);
                }
                else if (type == "parrot")
                {
                    animal = new Parrot(name, age, type, weight, habitat);
                }
                else if (type == "elephant")
                {
                   animal = new Elephant(name, age, type, weight, habitat);
                }

                animals.Add(animal);
            }

            foreach (var item in animals)
            {
                Console.WriteLine(item);
                item.MakeSound();
                item.Feed();
                item.Sleep();
            }

        }
    }
}

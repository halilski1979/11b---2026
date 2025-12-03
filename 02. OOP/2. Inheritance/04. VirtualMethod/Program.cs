namespace _04._VirtualMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            
            Animal animal=new Animal();           
            Animal dog=new Dog();                         
            Animal cat=new Cat();

            animals.Add(animal);
            animals.Add(dog);
            animals.Add(cat);

            foreach (var item in animals)
            {
                item.MakeSound();
            }
            

        }
    }
}

namespace _01._NasledqvaneNaNiva
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Puppy p=new Puppy();

            p.Eat();
            p.Bark();
            p.Weep();

            Console.WriteLine();
            Dog d=new Dog();
            d.Bark();
            Cat c=new Cat();
            c.Meow();

            Animal animal = new Cat();
            Animal animal1 = new Dog();
        }
    }
}

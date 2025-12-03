namespace _04.Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Ivan",22,2000);
            Person p1 = new Person("Asen",23,3000);
            Person p2 = new Person("Kiko", 23, 3000);

            p.Name = "Kiril";
            Console.WriteLine(p);
            Console.WriteLine(Person.Count());
           
            
        }
    }
}

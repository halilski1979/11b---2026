namespace _01._Person
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p=new Person();
            p.name= "Ivan";
            p.age = 17;

            Person p2 = new Person();
            p2.name = "Kiril";
            p2.age = 20;

            Console.WriteLine($"Name: {p.name},Age: {p.age}");
            Console.WriteLine(p);

            Console.WriteLine();
            Console.WriteLine(p2.ToString());
        }
    }
}

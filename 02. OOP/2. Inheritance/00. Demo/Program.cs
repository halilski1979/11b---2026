namespace _00._Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Ivan",22,"Adres 1");
            Console.WriteLine(p);

            Student s = new Student("Petar",22,"Adress 2","SoftUni");
            Console.WriteLine(s);

            Console.WriteLine();
            p.Sleep();
            s.Sleep();

            Console.WriteLine();
            s.Study();

            Console.WriteLine();
            Employee e = new Employee("Kiril",33,"Adres 3","Unity");
            Console.WriteLine(e);
            e.Work();
        }
    }
}

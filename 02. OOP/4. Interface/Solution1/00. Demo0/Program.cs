namespace _00._Demo0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Ivan","Ivanov",1,25);
            p.DisplayInfo();
            p.Work();

            Person p2 = new Person("Ivan", "Ivanov", 4, 25,"Teacher");
            p2.DisplayInfo();
            p2.Work();

            IPerson p1 = new Person("Petar", "Petrov", 2, 26);
            p1.DisplayInfo();

            IWorker worker = new Person("Petar", "Petrov", 3, 26,"Driver");
            worker.Work();
            
        }
    }
}

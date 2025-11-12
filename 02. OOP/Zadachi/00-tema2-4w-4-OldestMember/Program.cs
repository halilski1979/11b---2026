namespace _00_tema2_4w_4_OldestMember
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Family ivanovi = new Family();
            var line = Console.ReadLine().Split(' ').ToList();

            for (int i = 0; i < n; i++)
            {
                string name = line[0];
                int age=int.Parse(line[1]);

                Person p=new Person(name,age);
                ivanovi.AddMember(p);
                line = Console.ReadLine().Split(' ').ToList();
            }

            Person old=ivanovi.GetOldest();
            Console.WriteLine(old); 
        }
    }
}

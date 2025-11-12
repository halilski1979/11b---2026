using System.Net.Mail;

namespace _01_tema2_w4_5_Prouchvane
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var cmd = Console.ReadLine().Split(" ").ToList();
            People people = new People();

            for (int i = 0; i < n; i++)
            {
                string name = cmd[0];
                int age = int.Parse(cmd[1]);

                Person p = new Person(name, age);
                people.AddMember(p);
                cmd = Console.ReadLine().Split(" ").ToList();
            }



            people.Over30Years();
            people.Print();

        }
    }
}

namespace _02._PersonProperties
{
   public class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();

            p.Name= "Ivan";
            p.Age = 25;
            p.Salary = 2000.40;

            Console.WriteLine(p.ToString());
            p.IntroduceYourself();
            Console.WriteLine(p.Print());

            Console.WriteLine();
            Console.WriteLine(p.IncreaseSalary(10));
            p.IntroduceYourself();

            Console.WriteLine("===========");
            Person p2 = new Person("  ",23,2000);
            p2.IntroduceYourself();
        }


    }
}

namespace _02._PersonProperties
{
   public class Program
    {
        static void Main(string[] args)
        {
          var input=Console.ReadLine().Split(' ').ToList();
            List<Person> persons = new List<Person>();

            while (true)
            {
                if (input[0]=="Stop")
                {
                    break;
                }
                string name=input[0];
                int age=int.Parse(input[1]);
                double salary=double.Parse(input[2]);
                Person p=new Person(name,age,salary);
                persons.Add(p);

                input = Console.ReadLine().Split(' ').ToList();
            }
            foreach (var item in persons)
            {
                Console.WriteLine(item.ToString());
            }

        }


    }
}

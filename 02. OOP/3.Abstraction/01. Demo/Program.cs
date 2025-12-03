namespace _01._Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Не може да се създава обект от абстрактен клас
            //Person p=new Person();

            Student s = new Student("Ivan","Ivanov",23,"SoftUni");
            s.FullName();
            Console.WriteLine(s.GetDetails());

            Console.WriteLine();
            Employee e = new Employee("Petar","Petrov",23,"Teacher",3000);
            e.FullName();
            Console.WriteLine(e.GetDetails());
            Console.WriteLine(e.IntroduceYourSelf());

        }
    }
}

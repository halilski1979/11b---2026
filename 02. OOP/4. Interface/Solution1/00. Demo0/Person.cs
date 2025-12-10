using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00._Demo0
{
    internal class Person : IPerson,IWorker
    {
       
        public string FirstName { get ; set ; }
        public string LastName { get ; set ; }
        public int Id { get ; set ; }
        public int Age { get ; set ; }
        public string Job { get ; set ; }

        public Person(string firstName, string lastName, int id, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            Age = age;
            Console.WriteLine($"Person is created!");
            Console.WriteLine();
        }

        public Person(string firstName, string lastName, int id, int age, string job)
            : this(firstName, lastName, id, age)
        {
            Job = job;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"ID:[{Id}]  Name: {FirstName} {LastName}, {Age} years old!");
        }

        public void Work()
        {
            Console.WriteLine($"ID:[{Id}]  Name: {FirstName} {LastName}, {Age} years old!, Job:{Job}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00._Demo
{
    internal class Student : Person
    {
        private string school;

        public string School
        {
            get { return school; }
            set { school = value; }
        }

        public Student(string name, int age, string adress, string school) : base(name, age, adress)
        {
            this.School = school;
        }

        public override string ToString()
        {
            return $"{GetType().Name}:  {this.Name} , {this.Age} years old, Adress: {this.Adress}. School: {this.School}";
        }

        public void Sleep()
        {
            Console.WriteLine($"{GetType().Name} {this.Name} is sleepeng at the moment.");
        }

        public void Study()
        {
            Console.WriteLine($"{GetType().Name} now study!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Human_Izpit
{
    public class Student : Human
    {
        public double Grade { get;private set; }

        public Student(string firstName, string lastName, int age, double grade) : base(firstName, lastName, age)
        {
            this.Grade = grade;
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}, {this.Age} years old, grade: {this.Grade:f2}";
        }
    }
}

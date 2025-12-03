using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._Human_Izpit
{
    public class Student : Human
    {
        private double grade;

        public double Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        public Student(string firstName, string lastName, int age, double grade) : base(firstName, lastName, age)
        {
            this.Grade = grade;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}, {Age} years old, grade: {Grade:f2}";
        }
    }
}

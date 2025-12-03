using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._Human_Izpit
{
    public class Worker : Human
    {
        private double wage;
        private int workHours;

        public double Wage
        {
            get { return wage; }
            private set { wage = value; }
        }

        

        public int WorkHours
        {
            get { return workHours; }
            private set { workHours = value; }
        }




        public Worker(string firstName, string lastName, int age,double wage,int workhours) : base(firstName, lastName, age)
        {
            this.Wage = wage;
            this.WorkHours = workhours;
        }

        public double Salary()
        {
            double salary = wage * workHours;
            return salary;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}, {Age} years old, salary: {Salary:f2}";
        }
    }
}

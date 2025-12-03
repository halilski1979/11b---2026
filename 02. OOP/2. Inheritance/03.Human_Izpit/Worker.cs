using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Human_Izpit
{
    public class Worker : Human
    {
        public double Wage { get;private set; }
        public int WorkHours { get;private set; }


        public Worker(string firstName, string lastName, int age, double wage, int workHours) : base(firstName, lastName, age)
        {
            this.Wage = wage;
            this.WorkHours = workHours;
        }

        public double Salary()
        {
            double salary = Wage * WorkHours;
            return salary;
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}, {this.Age} years old, salary: {Wage * WorkHours:f2}.";
        }
    }
}

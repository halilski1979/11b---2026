using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _01._Demo
{
    public class Employee : Person
    {
        private string job;
        private double wage;

        public string Job
        {
            get { return job; }
            set { job = value; }
        }             

        public double Wage
        {
            get { return wage; }
            set { wage = value; }
        }


        public Employee(string fName, string sName, int age, string job, double wage) 
            : base(fName, sName, age)
        {
            this.Job = job;
            this.Wage = wage;
            Console.WriteLine($"Created Employee: {this.fName} {this.sName}");
        }

        public override string GetDetails()
        {
            return $"{fName} {sName} , {age} , {this.Job}";
        }

        public override string IntroduceYourSelf()
        {
            return base.IntroduceYourSelf() + $" I am {GetType().Name}, my job is {this.Job}";
        }
    }
}

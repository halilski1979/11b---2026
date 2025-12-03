using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00._Demo
{
    internal class Employee : Person
    {
        private string job;
        public string Job
        {
            get { return job; }
            set { job = value; }
        }

        public Employee(string name, int age, string adress, string job) 
            : base(name, age, adress)
        {
            this.Job = job;
        }


        public void Work()
        {
            Console.WriteLine($"{GetType().Name} know works!");
        }
    }
}

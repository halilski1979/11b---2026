using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Static
{
    public class Person
    {
		private string name;
        private int age;
        private double salary;

		private static int counter = 0;
		public static int Count()
		{
			return counter;
		}

        public Person(string name, int age, double salary)
        {
            this.Name = name;
            this.Age = age;
            this.Salary = salary;
			counter++;
            Console.WriteLine($"Sazdaden e nov obekt=>{this.Name},age:{this.Age},Salary: {this.Salary} euro.");
        }

        public string Name
		{
			get { return name; }
			set { name = value; }
		}		

		public int Age
		{
			get { return age; }
			set { age = value; }
		}		

		public double Salary
		{
			get { return salary; }
			set { salary = value; }
		}

        public override string ToString()
        {
			return $"{Name} -> {Age}";
        }

	}
}

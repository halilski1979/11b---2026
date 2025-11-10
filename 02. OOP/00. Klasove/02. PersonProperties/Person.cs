using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._PersonProperties
{
    public class Person
    {
		private string name;
        private int age;
        private double salary;

        public Person(string name, int age, double salary)
        {
            this.Name = name;
            this.Age = age;
            this.Salary = salary;
        }

		
		//Default construktor
		public Person()
		{

		}

        public string Name
		{
			get { return name; }
			set 
			{ if (value.Length < 2 || string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentException("Prazno ime ili po-malko ot 2 simvola!");
				}
				name = value; 
			}
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

        public void IntroduceYourself()
		{
            Console.WriteLine($"Kazvam se {this.Name}, na {this.Age},Zaplata: {this.Salary}");
		}
		
		public string  Print()
		{
			return $"Az sam {this.Name}....";
		}

		
		public override string ToString()
        {
            return $"My name is {this.Name}, {this.Age} age. Salary: {this.Salary}";
        }

		public double IncreaseSalary(double percent)
		{
			return this.Salary=this.Salary * (percent / 100) + this.Salary;
		}
	}
}

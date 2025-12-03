using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00._Demo
{
    public class Person
    {
		private string name;
        private int age;
        private string adress;

        public Person(string name, int age, string adress)
        {
            this.Name = name;
            this.Age = age;
            this.Adress = adress;
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
		public string Adress
		{
			get { return adress; }
			set { adress = value; }
		}

        public override string ToString()
        {
            return $"{GetType().Name}:  {this.Name} , {this.Age} years old, Adress: {this.Adress}";
        }

		public void Sleep()
		{
            Console.WriteLine($"{this.Name} now sleep!");
		}


	}
}

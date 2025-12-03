using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Human_Izpit
{
    public class Human
    {
        

        public string FirstName { get;private set; }
        public string LastName { get;private set; }
        public int Age { get;private set; }

        public Human(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public override string ToString()
		{
			return $"{this.FirstName} {this.LastName}, {this.Age} years old";
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_tema2_4w_4_OldestMember
{
    public class Person
    {
		private string name;
        private int age;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
		{
			get { return name; }
			set 
			{ 
			    if (value.Length < 2 || string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentException("Greshno ime!");
				}
				name = value;
			}
		}

		

		public int Age
		{
			get { return age; }
			set 
			{
				if (value<=0)
				{
					throw new ArgumentException("Greshni godini");
				}
				age = value;
			}
		}

        public override string ToString()
        {
			return $"{this.Name} {this.Age}";
        }



	}
}

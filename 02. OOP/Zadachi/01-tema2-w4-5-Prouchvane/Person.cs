using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_tema2_w4_5_Prouchvane
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
				if (value.Length<2 || string.IsNullOrWhiteSpace(value))
						{
					throw new ArgumentException("Error age.");
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
					throw new ArgumentException("Error in age");
				}
				age = value; 
			}
		}


        public override string ToString()
        {
			return $"{this.Name} - {this.Age}";
        }

	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._Abstract_Zoo
{
    public abstract class Animal
    {
		private string name;
        private int age;
        private string type;

        protected Animal(string name, int age, string type)
        {
            this.Name = name;
            this.Age = age;
            this.Type = type;
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

		public string Type
		{
			get { return type; }
			set { type = value; }
		}

		public abstract string MakeSound();

    }
}

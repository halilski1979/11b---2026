using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._AnimalKingdom
{
    public abstract class Animal : IMakeNoise, IMakeTrick
    {
        public string Name { get; set; }
        public int Age { get; set; }
        protected Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string MakeNoise()
        {
            return $"My name is {Name}. I am {Age} years old.";
        }

        public string MakeTrick()
        {
            return "Look at my trick!";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._AnimalKingdom
{
    public class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age)
        {
            Name = name;
            Age = age;
        }

        public string MakeNoise()
        {
            return $"Meow! \n {MakeNoise()}";
        }

        public string MakeTrick()
        {
            return "No trick for you! I'm too lazy!";
        }
    }
}

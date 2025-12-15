using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._AnimalKingdom
{
    public class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age)
        {
            Name = name;
            Age = age;
        }

        public string MakeNoise()
        {
            return $"Woof! \n {MakeNoise()}";
        }

        public string MakeTrick()
        {
            return "Hold my paw, human!";
        }
    }
}

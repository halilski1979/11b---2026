using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._Abstract_Zoo
{
    public class Lion : Animal
    {
        public Lion(string name, int age, string type) : base(name, age, type)
        {
        }

        public override string MakeSound()
        {
            return $"I am {GetType().Name} roaaaar!";
        }
    }
}

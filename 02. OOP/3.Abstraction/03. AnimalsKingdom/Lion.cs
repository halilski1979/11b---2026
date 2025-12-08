using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._AnimalsKingdom
{
    internal class Lion : Animal
    {
        public Lion(string name, int age, string type, double weight, string habitat) : base(name, age, type, weight, habitat)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine($"Roar...");
        }


    }
}

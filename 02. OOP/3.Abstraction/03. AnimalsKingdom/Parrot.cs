using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._AnimalsKingdom
{
    public class Parrot : Animal
    {
        public Parrot(string name, int age, string type, double weight, string habitat) : base(name, age, type, weight, habitat)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("What's up?");
        }
    }
}

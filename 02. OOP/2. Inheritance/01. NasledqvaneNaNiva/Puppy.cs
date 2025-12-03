using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._NasledqvaneNaNiva
{
    public class Puppy : Dog
    {
        public void Weep()
        {
            Console.WriteLine($"{GetType().Name} is weeping...");
        }
    }
}

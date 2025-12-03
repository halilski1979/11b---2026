using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._VirtualMethod
{
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal make sound...");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace _01._NasledqvaneNaNiva
{
    public class Cat:Animal
    {
        public void Meow()
        {
            Console.WriteLine($"{GetType().Name} meowwwwwww.....");
        }
    }
}

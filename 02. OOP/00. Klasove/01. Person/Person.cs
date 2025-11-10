using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._Person
{
    public class Person
    {
       public string name;
       public int age;

        public override string ToString()
        {
            return $"Kazvam se {this.name}. Az sam na {this.age} godini!";
        }
    }
}

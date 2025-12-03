using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._Demo
{
    public abstract class Person
    {
        // Полета
        public string fName;
        public string sName;
        public int age;

        protected Person(string fName, string sName, int age)
        {
            this.fName = fName;
            this.sName = sName;
            this.age = age;
        }

        //•	Деклариран е без тяло в абстрактен клас.
        //•Трябва задължително да бъде имплементиран в наследяващия клас.
        public abstract string GetDetails();

        public virtual string IntroduceYourSelf()
        {
            return $"My name is {fName} {sName}.";
        }


        public void FullName()
        {
            Console.WriteLine($"{this.fName}  {this.sName}");
        }

       

    }
}

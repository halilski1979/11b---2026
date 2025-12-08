using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._AnimalsKingdom
{
    public abstract class Animal
    {
      

        public string Name { get;private  set; }
        public int Age { get;private set; }
        public string Type { get;private set; }
        public double Weight { get;private set; }
        public string Habitat { get;private set; }

        protected Animal(string name, int age, string type, double weight, string habitat)
        {
            Name = name;
            Age = age;
            Type = type;
            Weight = weight;
            Habitat = habitat;
        }

        public abstract void MakeSound();

        public void Feed()
        {
            Console.WriteLine($"{this.Name} is eating");
        }

        public void Sleep()
        {
            Console.WriteLine($"{this.Name} is sleeping");
        }


        public override string ToString()
        {
            return $"{Name},a {Type},is {Age} years old and weight {Weight} kg. \n Habitat: {Habitat}";
        }
    }
}

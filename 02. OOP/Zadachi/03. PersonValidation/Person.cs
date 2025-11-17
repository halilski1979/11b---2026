using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._PersonValidation
{
    public class Person
    {
        private string firstname;
        private string lastname;
        private int age;
        private double salary;

        public Person(string firstname, string lastname, int age, double salary)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Age = age;
            this.Salary = salary; 
        }

        public string FirstName
        {
            get { return firstname; }
            set 
            { 
                if (value.Length < 3)
                {
                    throw new ArgumentException("trqbwa da sa pone 3 bukvi");
                }
                firstname = value;
            }
        }
        public string LastName
        {
            get { return lastname; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("trqbwa da sa pone 3 bukvi");
                }
                lastname = value;
            }
        }
        public int Age
        {
            get { return age; }
            set {
                if (value < 0)
                {
                    throw new ArgumentException("ne trqbwa da e po malko ot 0");
                }
                age = value;
            }
        }
        public double Salary
        {
            get { return salary; }
            set 
            {
                if (value < 460)
                {
                    throw new ArgumentException("ne moje da e po malko ot 460");
                }
                salary = value;
            }
        }

        public double IncreaseSalary(double bonus)
        {
            if (this.age > 30)
            {
                return salary += salary * (bonus / 100);
            }
            else
            {
                return salary += salary * ((bonus / 2) / 100);
            }
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} get {this.Salary:f2} leva";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._Demo
{
    public class Student : Person
    {
        private string school;

        public string School
        {
            get { return school; }
            set { school = value; }
        }

        public Student(string fName, string sName, int age, string school) : base(fName, sName, age)
        {
            this.School = school;
        }

        public override string GetDetails()
        {
            return $"{fName} {sName} , {age} , {school}";
        }
    }
}

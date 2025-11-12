using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_tema2_w4_5_Prouchvane
{
    public class People
    {
		private List<Person> hora = new List<Person>();

		public List<Person> Hora
		{
			get { return hora; }
			set { hora = value; }
		}

		public void AddMember(Person person)
		{
			hora.Add(person);
		}

		public void Over30Years()
		{
			hora = hora.Where(x => x.Age > 30).OrderBy(x => x.Age).ToList();
		}

		public void Print()
		{
			foreach (Person person in hora)
			{
                Console.WriteLine(person);
			}
		}
	}
}

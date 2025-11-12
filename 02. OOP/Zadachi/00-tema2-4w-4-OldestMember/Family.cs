using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_tema2_4w_4_OldestMember
{
    public class Family
    {
		private List<Person> members=new List<Person>();

		public List<Person> Members
		{
			get { return members; }
			set { members= value; }
		}


		public void AddMember(Person member)
		{
			members.Add(member);
		}
		public Person GetOldest()
		{
			return members.OrderByDescending(x => x.Age).FirstOrDefault();			 
		}


	}
}

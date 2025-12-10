using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00._Demo0
{
    public interface IPerson
    {
        //Нямамем модуфикатори за достъп - ВСИЧКИ СА public
        string FirstName { get; set; }
        string LastName { get; set; }
        int Id { get; set; }
        int Age { get; set; }
       
        
        void DisplayInfo();
    }
}

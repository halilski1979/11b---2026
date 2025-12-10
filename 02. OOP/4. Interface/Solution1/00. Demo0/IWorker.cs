using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00._Demo0
{
    public interface IWorker
    {
        string Job { get; set; }

        void Work();
    }
}

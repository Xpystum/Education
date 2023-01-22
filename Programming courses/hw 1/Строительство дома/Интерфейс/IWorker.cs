using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Строительство_дома.Дом;

namespace Строительство_дома.Интерфейс
{
    internal interface IWorker
    {
       public bool StatusWork { get; set; }
       public bool checkJobs(); 
       public  bool jobs(House house);
    }
}

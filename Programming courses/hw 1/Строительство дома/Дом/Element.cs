using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Строительство_дома.Интерфейс;

namespace Строительство_дома.Дом
{
    abstract class Element : IPart
    {
        public string? Name { get; set; }

        public virtual string? GetName()
        {
            return Name;
        }
       
    }
}

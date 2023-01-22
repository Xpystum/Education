using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Строительство_дома.Интерфейс;

namespace Строительство_дома.Дом
{
    internal class Walls : Element
    {
        public string? name
        {
            get { return Name; }
            set { Name = "Стена"; }
        }

        public Walls()
        {
            name = " ";
        }

        public override string? GetName()
        {
            return   name;
        }
    }
}

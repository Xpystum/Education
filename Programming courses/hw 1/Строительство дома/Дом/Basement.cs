using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Строительство_дома.Интерфейс;

namespace Строительство_дома.Дом
{
    internal class Basement : Element, IPart
    {
        public string? name
        {
            get { return Name; }
            set { Name = "Фундамент"; }
        }

        public Basement()
        {
            name = " ";
        }

        public override string? GetName()
        {
            return name;
        }
    }
}

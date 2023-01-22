using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Строительство_дома.Интерфейс;

namespace Строительство_дома.Дом
{
    internal class Window : Element, IPart    {
        public string? name
        {
            get { return Name; }
            set { Name = "Окно"; }
        }

        public Window()
        {
            name = " ";
        }

        public override string? GetName()
        {
            return name;
        }


        //private string? _Name;

        //public string? Name
        //{
        //    get { 
        //        return _Name; 
        //    }
        //    set { 
        //        _Name = "Окно"; 
        //    }
        //}

    }
}

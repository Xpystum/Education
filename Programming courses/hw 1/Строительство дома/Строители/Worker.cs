using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Строительство_дома.Дом;
using Строительство_дома.Интерфейс;

namespace Строительство_дома.Строители
{

    struct DateElements : IEnumerable
    {
        ArrayList _element;

        public Basement basement { get;}
        public Walls walls { get; }
        public Door door { get; }
        public Window window { get; }
        public Roof roof { get; }  
        public DateElements() 
        {
            basement= new Basement();
            walls= new Walls();
            door= new Door();
            window= new Window();
            roof= new Roof();
            _element = new ArrayList() { basement,walls,door,window,roof };
        }
        public IEnumerator GetEnumerator() => _element.GetEnumerator(); 
    }
    internal class Worker : IWorker
    {
        DateElements data_elements = new DateElements();

        public Element? element { get; private set; } //что последнее строил рабочий - можно вернуть string имя элемента
        public string? _FIO { get; set; }
        public string? _Name_firm { get; set; }
        public bool StatusWork { get; set; }

        //JobsString el = jobs;
        public Worker() 
        {
            _FIO = "FIO";
            _Name_firm = "Name Firm";
            StatusWork= false;
          
            
        }

        public Worker(string? fIO, string? name_firm, bool statusWork = false)
        {
            _FIO = fIO;
            _Name_firm = name_firm;
        }

        public virtual bool checkJobs()
        {
            return StatusWork;
        }

     
        public virtual bool jobs(House house)
        {
            StatusWork = true;
            if (house.AddElement(data_elements.basement)) { element = data_elements.basement; return StatusWork; }
            else if (house.AddElement(data_elements.walls)) { element = data_elements.walls; return StatusWork; }
            else if (house.AddElement(data_elements.door)) { element = data_elements.door; return StatusWork; }
            else if (house.AddElement(data_elements.window)) { element = data_elements.window; return StatusWork; }
            else if (house.AddElement(data_elements.roof)) { element = data_elements.roof; return StatusWork; }
            StatusWork = false;
            return StatusWork;
        }


    }
}

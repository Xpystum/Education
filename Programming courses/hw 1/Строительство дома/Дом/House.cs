using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Строительство_дома.Дом
{

    class HouseElement
    {
        //идеально сделать в private доступ - но тогда нужно будет делать ещё кучу методов
        //удаление элемента дома не будет предусмотренно
        public List<Element> list = new List<Element>(11); 
        private int? number_Basemet;
        public int? Number_Basemet
        {
            get { return number_Basemet; }
            set
            {
                if (number_Basemet == null)
                {
                    number_Basemet = 0;
                }
                else
                {
                    if (number_Basemet <= 1)
                    {
                        number_Basemet++;
                        TotalCount++;
                    }
                }

            }
        }

        private int? number_Door;
        public int? Number_Door
        {
            get { return number_Door; }
            set
            {
                if (number_Door == null)
                {
                    number_Door = 0;
                }
                else
                {
                    if (number_Door <= 1)
                    {
                        number_Door++;
                        TotalCount++;
                    }
                   
                }
            }
        }

        private int? number_Roof;
        public int? Number_Roof
        {
            get { return number_Roof; }
            set
            {
                if (number_Roof == null)
                {
                    number_Roof = 0;
                }
                else
                {
                    if (Number_Roof <= 1)
                    {
                        number_Roof++;
                        TotalCount++;
                    }
                }
            }
        }

        private int? number_Walls;
        public int? Number_Walls
        {
            get { return number_Walls; }
            set
            {
                if (number_Walls == null)
                {
                    number_Walls = 0;
                }
                else
                {
                    if (number_Walls <= 4)
                    {
                        number_Walls++;
                        TotalCount++;
                    }
                   
                }
            }
        }

        private int? number_Window;
        public int? Number_Window
        {
            get { return number_Window; }
            set
            {
                if (number_Window == null)
                {
                    number_Window = 0;
                }
                else
                {
                    if (number_Window <= 4)
                    {
                        number_Window++;
                        TotalCount++;
                    }

                }
            }
        }

        public int? TotalCount { get; set; }

        public HouseElement()
        {

            TotalCount = 0;
            Number_Basemet = 0;
            Number_Walls = 0;
            Number_Door= 0;
            Number_Window = 0;
            Number_Roof = 0;
            
        }

        public bool Contains(Element element)
        {
            return list.Contains(element);
        }

        public bool Add(Element? element) => Add(element, a => CheckDelegate(a));
        public bool Add(Element? element, Func<Element, bool> func)
        {

            switch (element)
            {
                case Basement:
                    {
                        bool Check = func(element ?? throw new NullReferenceException());
                        if (Check) { list.Add(element); Number_Basemet++; return Check; }
                        else { return Check; }

                    }
                case Door:
                    {
                        bool Check = func(element ?? throw new NullReferenceException());
                        if (Check) { list.Add(element); Number_Door++; return Check; }
                        else { return Check; }
                    }
                case Roof:
                    {
                        bool Check = func(element ?? throw new NullReferenceException());
                        if (Check) { list.Add(element); Number_Roof++; return Check; }
                        else { return Check; }
                    }
                case Walls:
                    {
                        bool Check = func(element ?? throw new NullReferenceException());
                        if (Check) { list.Add(element); Number_Walls++; return Check; }
                        else { return Check; }
                    }
                case Window:
                    {
                        bool Check = func(element ?? throw new NullReferenceException());
                        if (Check) { list.Add(element); Number_Window++; return Check; }
                        else { return Check; }
                    }
                default:
                    throw new NullReferenceException("Element был null");
            }

        }

        private bool CheckDelegate(Element element)
        {
            switch (element)
            {
                case Basement:
                    {
                        if (Number_Basemet == 0) return true; 
                        break; //можно не ставить
                        
                    }
                case Door:
                    {
                        if (Number_Door == 0) return true;
                        break;
                    }
                case Roof:
                    {
                        if (Number_Roof == 0) return true;
                        break;
                    }
                case Walls:
                    {
                        if (Number_Walls >=0 && Number_Walls < 4) return true;
                        break;
                    }
                case Window:
                    {
                        if (Number_Window >= 0 && Number_Window < 4) return true;
                        break;
                    }
                default:
                    throw new NullReferenceException("Element был null");
            }
            return false;
        }

    }

    class House
    {
       const string Name = "Дом";
       public bool CheckStatusBild { get; set; } // true - дом построен


        public HouseElement _element;

        public House()
        {
            _element = new HouseElement();
            CheckStatusBild = false;
        }

        /// <summary>
        /// Добавление элемента в дом.
        /// </summary>
        /// <param name="element"> элемент дома </param>
        /// <returns>Возвращаем false если элемент дома не добавлен - (либо неправильные данные, либо элементов больше чем уже должно быть)</returns>
        /// <exception cref="NullReferenceException"></exception>
        public bool AddElement(Element element) 
        {
            try
            {
                if (_element.TotalCount == 11) CheckStatusBild = true;
                
                return _element.Add(element);
            }
            catch 
            {

                throw new NullReferenceException("Element был null");
            }

        }


            
            //if (_element.Number_Basemet == 0 && !_element.Contains(element as Basement))
            //{
            //    _element.Add(element);
            //    Console.WriteLine("Добавлен элемент");
            //}
            //else if(_element.Number_Walls <= 4)
            //{

            //}

        

        public string GetStatusBild()
        {
            if (CheckStatusBild) return $"{Name} Построен";
            return $"{Name} Не построен";
        }

    }
}
    


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonLibrary;

namespace KT6
{
    class MyPersonList : PersonList

    {
        int Age;

        public int Age1 { get => Age; set => Age = value; }

        public override void Add(PersonPlus person)
        {
            if (Age >= 18)
            {
                personList.Add(person);
            }
            
                      
        }

        public override PersonPlus GetAt(int index)
        {
            if (Age >= 20)
            {
                return base.GetAt(index);
            }

            else
            {
                return null;
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

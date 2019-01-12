using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT3._1
{
    class Ope
    {

        public string OpeName
        {
            get;
            set;
        }

        public int OpeId
        {
            get;
            set;
        }

        public override string ToString()
        {
            Console.WriteLine("Opettaja:");
            return "ID: " + OpeId + "   Name:   " + OpeName;
            //ID, mones luku ja näin ja + opettajien nimi
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Ope objAsOpe = obj as Ope;

            if (objAsOpe == null)
                return false;
            else return Equals(objAsOpe);

        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public bool Equals(Ope other)
        {
            if (other == null) return false;
            return (this.OpeId.Equals(other.OpeId));
        }


    }
}

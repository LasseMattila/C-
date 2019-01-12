using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT3._1
{
    class Moduuli
    {

        public string ModuuliName
        {
            get;
            set;
        }

        public int ModuuliId
        {
            get;
            set;
        }

        public override string ToString()
        {
            Console.WriteLine("Moduuli:");
            return "ID: " + ModuuliId + "   Name:   " + ModuuliName;
            //ID, mones luku ja näin ja + opettajien nimi
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Moduuli objAsModuuli = obj as Moduuli;

            if (objAsModuuli == null)
                return false;
            else return Equals(objAsModuuli);

        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public bool Equals(Moduuli other)
        {
            if (other == null) return false;
            return (this.ModuuliId.Equals(other.ModuuliId));
        }


    }
}

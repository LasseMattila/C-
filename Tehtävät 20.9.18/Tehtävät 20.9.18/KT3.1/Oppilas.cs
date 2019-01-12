using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT3._1
{
    class Oppilas
    {

        public string OppilasName
        {
            get;
            set;
        }
        public int OppilasId
        {
            get;
            set;
        }

        public override string ToString()
        {
            Console.WriteLine("Oppilas:");
            return "ID: " + OppilasId + "   Name: " + OppilasName;
            //ID, mones luku ja näin ja + oppilaan nimi

        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Oppilas objOppilas = obj as Oppilas;
            if (objOppilas == null) return false;
            else return Equals(objOppilas);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public bool Equals(Oppilas Other)
        {
            if (Other == null) return false;
            return (this.OppilasId.Equals(Other.OppilasId));
        }


    }
}

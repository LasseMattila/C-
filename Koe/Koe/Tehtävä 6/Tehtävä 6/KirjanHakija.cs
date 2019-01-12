using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_6
{
    public class KirjanHakija : Hakija
    {
        

        public KirjanHakija()
        {

        }
       

        public override string HaeTiedot(int indeksi)
        {
            return "Indeksi on" + indeksi;
        }
    }
}

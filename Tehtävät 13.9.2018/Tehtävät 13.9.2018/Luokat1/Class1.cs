using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luokat1
{
    class Tervehtijä
    {
        string tervehdys;
        public void AsetaTervehdys(string uusiTervehdys)
        {

            tervehdys = uusiTervehdys;

        }


        public void Tervehdi()
        {

            Console.WriteLine("Tere!");

        }

       

        public void Tervehdi(string omaTervehdys)
        {

            tervehdys = omaTervehdys;

        }


        public string HaeTervehdys()
        {
            return "Moro!";
        }
    }
}

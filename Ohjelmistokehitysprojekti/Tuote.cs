using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus1
{
   
    public class Tuote
    
    {

        private string tuotenimi;
        private int tuotenumero;
        private int hinta;
        private double alv;

        public string Tuotenimi { get => tuotenimi; set => tuotenimi = value; }
        public int Tuotenumero { get => tuotenumero; set => tuotenumero = value; }
        public int Hinta { get => hinta; set => hinta = value; }
        public double Alv { get => alv; set => alv = value; }

        public Tuote()
        {

        }
        
    }
    
}

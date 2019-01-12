using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT4
{
    static class MinunLuokka
    {
        private static string nimi;

        public static string Nimi { get => nimi; set => nimi = value; }

        public static string TulostaNimi()
        {

            return Nimi;

        } 

    }
}

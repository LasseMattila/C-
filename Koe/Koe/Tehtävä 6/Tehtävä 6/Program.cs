using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_6
{
    class Program
    {
        static void Main(string[] args)
        {

            KirjanHakija kh = new KirjanHakija();

            Console.WriteLine(KirjanHakija.HaeTiedot());

        }
    }
}

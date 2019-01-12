using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luokat1
{
    class Program
    {
        static void Main(string[] args)
        {
            Tervehtijä tervehtijä = new Tervehtijä();
            tervehtijä.Tervehdi();
            Console.WriteLine(tervehtijä.HaeTervehdys());

            


            
        }
    }
}

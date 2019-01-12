using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_5
{
    class Program
    {
        static void Main(string[] args)
        {

            StringBuilder sb = new StringBuilder("yksi kaksi kolme");
            sb.Insert(0, "nolla ");
            sb.Remove(16, 6);



            Console.WriteLine(sb.ToString());

        }
    }
}

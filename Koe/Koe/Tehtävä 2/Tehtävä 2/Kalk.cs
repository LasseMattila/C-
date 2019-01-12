using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_2
{
    class Kalk
    {

        double luku1;
        double luku2;
        double luku3;

        public double Luku1 { get => luku1; set => luku1 = value; }
        public double Luku2 { get => luku2; set => luku2 = value; }

        public Kalk()
        {

        }
        public Kalk(double luku1, double luku2)
        {
            luku1 = 1;
            luku2 = 7;
        }
        

        public override string ToString()
        {
            return luku3.ToString(luku1 + "&" + luku2);
        }
    }
}

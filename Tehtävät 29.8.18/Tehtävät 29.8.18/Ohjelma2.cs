using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laskuri1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Yhteen-vai vähennyslasku (+/-)");
            string teksti = Console.ReadLine();


            Console.WriteLine("Anna ensimmäinen luku");
            var num1 = Console.ReadLine();
            int luku1 = int.Parse(num1);

            Console.WriteLine("Anna toinen luku");
            var num2 = Console.ReadLine();
            int luku2 = int.Parse(num2);

            if (teksti.ToLower().Contains("yhteen"))
            {
                int luku3 = luku1 + luku2;
                Console.WriteLine(luku3);
            }

            else
            {
                int luku3 = luku1 - luku2;
                Console.WriteLine(luku3);
            }

            

        }
    }
}


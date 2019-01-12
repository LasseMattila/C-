using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_4
{
    class Program
    {
        static void Main(string[] args)
        {

            

            try
            {

                StreamReader reader = File.OpenText("C:\\Users\\it16\\source\\repos\\harjotus\\harjotus\\bin\\Debug\\asetukset.txt");
                string line = reader.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = reader.ReadLine();

                }
                reader.Close();
            }
            catch (FileNotFoundException ex) { Console.WriteLine(ex.Message); }
        }
    }
}

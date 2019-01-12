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

            double sum = 0, avg = 0;

            Console.Write("Montako lukua?");
            int n = Int32.Parse(Console.ReadLine());
            double[] numbers = new double[n];

            for (int i = 0; i < numbers.Length; i++)

            {
                Console.Write("Anna numero: {0}: ", i + 1);
                numbers[i] = Convert.ToDouble(Console.ReadLine());
                sum += numbers[i];
            }

            avg = sum / numbers.Length;

            Console.WriteLine("Keskiarvo : " + avg);

            Console.ReadKey();

        }
    }
}

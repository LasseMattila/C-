using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT3._1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Opettaja 
            List<Ope> ope = new List<Ope>();
            ope.Add(new Ope() { OpeName = "Fysiikka", OpeId = 1 });
            ope.Add(new Ope() { OpeName = "Matematiikka", OpeId = 2 });
            ope.Add(new Ope() { OpeName = "Celcius", OpeId = 3 });

            //Oppilas lista
            List<Oppilas> oppilas = new List<Oppilas>();
            oppilas.Add(new Oppilas() { OppilasName = "Derivaatta", OppilasId = 1 });
            oppilas.Add(new Oppilas() { OppilasName = "Kulmakerroin", OppilasId = 2 });

            //moduuli luokka
            List<Moduuli> moduuli = new List<Moduuli>();
            moduuli.Add(new Moduuli() { ModuuliName = "Hamk", ModuuliId = 1 });
            moduuli.Add(new Moduuli() { ModuuliName = "Tamk", ModuuliId = 2 });
            moduuli.Add(new Moduuli() { ModuuliName = "Xamk", ModuuliId = 3 });
            moduuli.Add(new Moduuli() { ModuuliName = "Metropolia", ModuuliId = 4 });



            //ID on pelkä sarjanumero / mones henkilö

            /*console.writeline määrittyy mitkä tulevat tulostuksessa ensimmäisenä
             * esim tässä foreach(Ope aOpe in ope) tulostuu ensimmäisenä
             * mutta jos foreach(Oppilas aOppilas in oppilas) käänteisessä vaan
             * toi console.writeline() listan järjestys tulostus
             */
            Console.WriteLine();
            foreach (Ope aOpe in ope)
            {
                Console.WriteLine(aOpe);
            }

            Console.WriteLine();
            foreach (Oppilas aOppilas in oppilas)
            {
                Console.WriteLine(aOppilas);
            }

            Console.WriteLine();
            foreach (Moduuli aModuuli in moduuli)
            {
                Console.WriteLine(aModuuli);
            }

            Console.WriteLine("\nYhteensä::");

            Console.WriteLine("Opettajia & Lehtoria: {0}", ope.Count);
            Console.WriteLine("Oppilaita: {0}", oppilas.Count);

            Console.WriteLine("Moduuli luokka: {0}", moduuli.Count);
            /*tulostuu vain oma luokkan listan x määrä, mitä listassa lukee
             * että opettajien määrä, eli yhteenssä             
             */

            ope.TrimExcess();
            Console.WriteLine("\nOpettajia()");
            Console.WriteLine("Henkilöstö: {0}", ope.Count);
            //yhteenveto, että uusi rivi, jossa tunnistaa oman määrän mitäkin on yhteensä

            oppilas.TrimExcess();
            Console.WriteLine("\nWanted:()");
            Console.WriteLine("Oppilaita on: {0}", oppilas.Count);

            moduuli.TrimExcess();
            Console.WriteLine("\nLista: ()");
            Console.WriteLine("Moduuleita yhteensä: {0}",
            moduuli.Count);


        }
    }
}

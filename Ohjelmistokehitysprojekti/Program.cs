using Harjoitus1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _123
{
    class Program
    {
        static void Main(string[] args)
        {

            //alku asiakkaan yhteistiedot
            int numero;
            string nimi;
            string sposti;
            int pnumero;

            //hinnan tiedot & yhteensumma
            double cost = 0;


            Tuote vessaharja = new Tuote();
            vessaharja.Hinta = 5;
            vessaharja.Tuotenumero = 65436;
            vessaharja.Tuotenimi = "Vessaharja";
            vessaharja.Alv = 0.24;

            Tuote kukkapurkki = new Tuote();
            kukkapurkki.Hinta = 10;
            kukkapurkki.Tuotenumero = 89756;
            kukkapurkki.Tuotenimi = "Kukkapurkki";
            kukkapurkki.Alv = 0.24;

            Tuote porakone = new Tuote();
            porakone.Hinta = 50;
            porakone.Tuotenumero = 71457;
            porakone.Tuotenimi = "Porakone";
            porakone.Alv = 0.24;

            Tuote imuri = new Tuote();
            imuri.Hinta = 100;
            imuri.Tuotenumero = 07234;
            imuri.Tuotenimi = "Imuri";
            imuri.Alv = 0.24;

            Tuote koira = new Tuote();
            koira.Hinta = 1;
            koira.Tuotenumero = 12138;
            koira.Tuotenimi = "Koira";
            koira.Alv = 0.24;

            Tuote kuulokkeet = new Tuote();
            kuulokkeet.Hinta = 27;
            kuulokkeet.Tuotenumero = 04535;
            kuulokkeet.Tuotenimi = "Kuulokkeet";
            kuulokkeet.Alv = 0.24;



            /*-
            - randomi char luvut, esim tossa 0-9. jonka tulee "tilauks_":ksen jälkeen tuleva randomiluku, 
            - toki voidaan lisätä erikoismerkkejä tai aakkosia
            
            - mutta kun käyttäjä/asiakkas tallentaa tiedot, tulee liian pitkä jos lukee ==>
            - "tilaukse_" joku luku & aakkoset & erikoismerkkit + päiväys ja tarkka aika, koska se on liian pitkä!
                        
             */


            string chars = "0123456789";


            Random rnd = new Random();
            string name;
            do
            {


                name = string.Empty;
                while (name.Length < 7)
                {

                    name += "Tilaus_" + chars.Substring(rnd.Next(chars.Length), 1) + DateTime.Now.ToString("_yyyy_MM_dd_");
                    //tulostuu Tilaus_5_2018_10_09_
                    //eli nimi + random luku char:ilsta + päiväys (vvvv.kk.pp)
                }

                name += ".txt";



            } while (File.Exists(Path.Combine(@"C:\temp\development-team-05\development-team-05\Harjoitus1\Harjoitus1\bin\Debug\", name)));

            StreamWriter streamWriter = new StreamWriter(name);

            List<Tuote> tuotelista = new List<Tuote>();

            //alku tervehdys
            Console.WriteLine("Tervetuloa verkkokauppaan!".ToUpper());


            Console.WriteLine("\nOle hyvä ja anna yhteystietosi");
            streamWriter.WriteLine("Asiakkaan yhteystiedot:");

            Console.WriteLine("\nNimi:");
            nimi = Console.ReadLine();
            streamWriter.WriteLine("Nimi: " + nimi);

            Console.WriteLine("\nSähköpostiosoite:");
            sposti = Console.ReadLine();
            streamWriter.WriteLine("Sposti: " + sposti);

            Console.WriteLine("\nPuhelinnumero:");
            pnumero = Convert.ToInt32(Console.ReadLine());
            streamWriter.WriteLine("pNumero: " + pnumero);


            //lisääntyy tilauksen tiedostoon, aika milloin asiakkas on tilannut tässä esim. aika ensimmäisenä sitten pp.kk.yyyy
            /* sekä tämä DateTime koodi/rivi, jossa on oikeat ajat ja päiväykset. eli visual studio että windows:in mukaan
             * tässä kunnes käyttäjä/asiakas on tallentanut tiedot (10) ja poistunut (0)
             * jos käyttäjä/asiakkas ei tallenna tietoa(10), siirtyy suoraan poistumaan (0) tiedot ei tallennu
             * tiedot tallentuu suoraan sinne notepadiin mitä on määritetty name += ".txt"
             * 
             * mallitulostuksen ajasta & tiedostossa & hinnat tilauksesta
             * 
             * Asiakkaan yhteystiedot:
             * Nimi: Alfa
             * Sposti: @outlook.com
             * pNUmero: 0100100
             * 17.29.30                                             (tässä on tunnit.min ja sekunnit)
             * 11.12.13                                             (päiväys pp.kk.yyyy)
             * Yhteenveto tilauksesta:
             * Summa 123
             * 
             * 1                                                    (käyttäjä/asiakkaan tilaukset)
             * 2
             * 3
             * 
             
             
             */

            DateTime wa = DateTime.Now;

            string Timeonly = wa.ToLongTimeString();

            streamWriter.WriteLine(Timeonly);

            //päiväys, milloin tilattu päivä
            DateTime dateAndTime = DateTime.Now;
            streamWriter.WriteLine(dateAndTime.ToString("dd/MM/yyyy"));

            Console.WriteLine("\nVoit poistua kaupasta valitsemalla numeron 0".ToUpper());
            Console.WriteLine("Voit tyhjentää ostoskorin valitsemalla numeron 9".ToUpper());
            Console.WriteLine("Voit vahvistaa tilauksen valitsemalla numeron 10".ToUpper());

            Console.WriteLine("\nVoit valita tuotteen ostoskoriin valitsemalla tuotteen numeron".ToUpper());


            do
            {



                Console.WriteLine("\n1. Vessaharja 5e\n2. Kukkapurkki 10e\n3. Porakone 50e\n4. Imuri 100e\n5. Koira 1e\n6. Langattomat kuulokkeet 27e + ale - 35%\n7. Valmiit tilaukset\n8. Palaute");
                Console.WriteLine("__________________");
                numero = Convert.ToInt32(Console.ReadLine());


                switch (numero)
                {

                    case 0:
                        Console.WriteLine("Kiitos käynnistä!".ToUpper());
                        tuotelista.Clear();
                        break;
                    case 1:
                        Console.WriteLine("\nTuote numero 1. on lisätty tilaukseen");
                        tuotelista.Add(vessaharja);
                        cost += 5;
                        break;

                    case 2:
                        Console.WriteLine("\nTuote numero 2. on lisätty tilaukseen");
                        tuotelista.Add(kukkapurkki);
                        cost += 10;
                        break;
                    case 3:
                        Console.WriteLine("\nTuote numero 3. on lisätty tilaukseen");
                        tuotelista.Add(porakone);
                        cost += 50;
                        break;
                    case 4:
                        Console.WriteLine("\nTuote numero 4. on lisätty tilaukseen");
                        tuotelista.Add(imuri);
                        cost += 100;
                        break;
                    case 5:
                        Console.WriteLine("\nTuote numero 5. on lisätty tilaukseen");
                        tuotelista.Add(koira);
                        cost += 1;
                        break;

                    //alennus tuote, eli esim tuotteesta * sen prosenttin ale
                    //se lisääntyy suoraan automaatisesti muiden tuoteiden kanssa yhteen
                    //jos käyttäjä/asiakkas haluu (6) niin se laskee ton 27*0,35 ensin => 9.45
                    //sitten toi alennus tuote lisääntyy suoraan "+" muiden tuoteiden kanssa yhteen
                    //toki se laskee vielä ton alv prosenttin

                    case 6:
                        Console.WriteLine("\nTuote numero 6. on lisätty tilaukseen");
                        tuotelista.Add(kuulokkeet);
                        cost += 27 * 0.35;
                        break;

                        //jos yrität avatta tiedoston, muuta nimi ensin ==> @"se tiedosto kansio, mihin yrität tallentaakaan"
                    case 7:
                        Console.WriteLine("Avaat tilaukset");
                        System.Diagnostics.Process.Start(@"C:\temp\development-team-05\development-team-05\Harjoitus1\Harjoitus1\bin\Debug\");
                        break;

                    //Asiakas & käyttäjä jättää viestin (Palautetta & kommentia & turhia murheita)
                    case 8:
                        Console.WriteLine("Viesti & enintään 5 riviä, kiitos!!! \nOhje!: enintään 5-riviä & 5-enteriä jos ei ole murheita/kommentia/palautetta, kiitos!!");
                        string[] names = new string[5];
                        for (int i = 0; i < 5; i++)
                        {
                            names[i] = Console.ReadLine();

                        }

                        //palauteen tiedoston nimi
                        string chars2 = "0123456789";
                        Random SMS = new Random();

                        StreamWriter SW = new StreamWriter(@"Palaute_" + chars2.Substring(SMS.Next(chars2.Length), 1) + "_" + nimi + ".txt");

                        for (int i = 0; i < 5; i++)
                        {
                            SW.WriteLine(names[i]);

                        }


                        SW.Close();
                        /*Jos asiakkas/käyttäjä laittaa palauteen, esim vähä nii kui jos tuote ei löydy noista valikosta
                         * nii lisää, mielellään kirjoitta kokonaisin lausein. koska max 5 riviä niin se lopettaa sen
                         * myös sama homma vaikka olisi alle 5 viisi tuotetta, niin näppytää vaa lopput enterit, niin pääsee takaisin ostos luettelloon
                         * 
                         * esim jos tilauksesta:::
                         * 
                         * 8
                         * Viesti & enintään 5 riviä, kiitos!!!
                         * Ohje!: enintään 5-riviä & 5-enteriä jos ei ole murheita/kommentia/palautetta, kiitos\n!!
                         * Tomaatti                                                     (1) ensimmäinen tuote
                         * Kakku, vehnäjauho, sokeria, suolaa ja hiivaa                 (2)
                         * Sinihome                                                     (3)
                         * 5 000 litralista Gin Martinia                                (4)
                         * pari sataa murhetta                                          (5) viimeinen tuote
                         * 
                         * - tosta sen jälkeen siirtyy takaisin suoraan ostoksiin eli taas::
                         * 1. Vessaharja 5$
                         * 2. Kukkapurkki
                         *
                         * - myös, jos asiakas/käyttäjä ei haluu lisää tuoteita ostoskoriin, niin tallentaa tiedot (10) ja poistuu kauppasta (0)
                         * - sen jälkeen tiedot/palaute siirtyy suoraan sinne tiedostoon nimellä "Palaute_X_YYYY DDD"
                         * - toi X tarkoittaa random luku 0-9, koska erillinen tiedosto
                         * - lisäksi YYYY DDD on ostajan nimi, kun alussa kysyttään yhteistiedot kuka on antanut mitäkin palautetta
                         * - jotta myyjä/omistaja tietää kuka on antanut palautetta ja mitäkin
                         * - vaikka asiakkas/käyttäjä ei anna palautetta (8), niin se ei sitten lisänny sinne tiedostoon
                         */
                        break;
                    case 9:
                        Console.WriteLine("Ostoskori tyhjennetty!");
                        tuotelista.Clear();
                        cost = 0;
                        break;
                    case 10:
                        Console.WriteLine("Tilaus vahvistettu! Voit poistua kaupasta valitsemalla numeron 0");
                        Console.WriteLine("Tervetuloa uudelleen!");
                        using (streamWriter)
                        {
                            streamWriter.WriteLine("Yhteenveto tilauksesta:");
                            //Console.WriteLine("Summa on {0} euroa", cost);
                            streamWriter.WriteLine("Summa " + cost);
                            streamWriter.WriteLine("Alv vero " + 0.24 * cost);

                            /*alv vero eli 24% tuotteesta, eli toi laskee kaikki käyttäjän/asiakkaan tuotteesta 0,24 * tuotteet
                             *siis tuotteen yhteensä, kaikken kaikkiaa sitten kertoo ton prosenttin
                             *sekä se tulostaa sen prosentti suuruuden, paljon se onkaan
                             * 
                             * malli tuotteesta::
                             * 
                             * 1     (vessaharja)    5€
                             * 2     (Kukkapurkki)   10€                        
                             * 4     (Imuri)         100€
                             * 3     (Porakone)      50€
                             * ___________________________
                             * yhteensä              165€                   (lasket vaan tuotteet yhteen 165 * 0,24 % = 39,60€)
                             * alv:                  39,60€
                             *
                             * 
                             *
                             * malli ale tuotteesta::
                             * 
                             * 4     (Imuri)                                100€
                             * 3     (Porakone)                             50€ 
                             * 6     (kuulokkeet + ale) 27 * 0,35%          9,45€   (Koska tässä  on muutettu desimaaliski,"check" alku riviltä jossa lukee double = cost;
                             * ____________________________________________________
                             * yhteensä                                     159,45€
                             * alv:                                         38,268€ (ei ole pakko olla mukana toi alv vero & myös viittaa double = cost; 
                             *                                                       koska se sisältyy siihen)
                             *
                         */

                            streamWriter.WriteLine("Tuotenimi\tTuotenumero\tHinta\tAlv");

                            for (int i = 0; i < tuotelista.Count(); i++)
                            {
                                Tuote listallaOlevaTuote = tuotelista[i];



                                string tuloste = $"{listallaOlevaTuote.Tuotenimi}\t{listallaOlevaTuote.Tuotenumero}\t{listallaOlevaTuote.Hinta}\t{listallaOlevaTuote.Alv}";

                                string csvRivi = $"{listallaOlevaTuote.Tuotenimi}\t{listallaOlevaTuote.Tuotenumero}\t\t{listallaOlevaTuote.Hinta}\t{listallaOlevaTuote.Alv}";


                                streamWriter.WriteLine(csvRivi);

                            }





                        }
                        break;
                    default:
                        Console.WriteLine("\nValitse jokin tuote, ole hyvä");
                        break;
                }

                for (int i = 0; i < tuotelista.Count(); i++)
                {
                    Tuote listallaOlevaTuote = tuotelista[i];

                    string tuloste = $"{listallaOlevaTuote.Tuotenimi}";


                    Console.WriteLine(value: "Ostoskorissa on seuraavat tuotteet: " + listallaOlevaTuote.Tuotenimi);
                }



                if (cost != 0)
                {
                    Console.WriteLine("Yhteensä {0} euroa.", cost);
                    Console.WriteLine("Alv: " + 0.24 * cost);
                }





            } while (numero != 0);



        }
    }
}

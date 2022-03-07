using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia69
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ika();
            Toistaluku();
            VaihdaKirjain();
            PosNeg();
            Pisinsana();
            ParittomatLuvut();
            KolmellaJaolliset();
        }
        static void Ika()
        {
            int ika;
            ialku:
            try
            {
                Console.WriteLine("Kirjoita tähän ikäsi: ");
                ika = Int32.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Syötä ikäsi numeroina");
                goto ialku;
            }
            Console.WriteLine(ika + " - näytät ikäistäsi nuoremmalta.");
        }
        static void Toistaluku()
        {
            int luku;
            lalku:
            try
            {
                Console.Clear();
                Console.WriteLine("Anna luku joka on suurempi kuin 10: ");
                luku = Int32.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Syötä kokonaisluku.");
                goto lalku;
            }
            for (int i = 0; i < luku; i++)
            {
                for (int j = 0; j < luku; j++)
                {
                    Console.Write(luku + " ");
                }
                Console.WriteLine();
                for (int k = 0; k < luku; k++)
                {
                    Console.Write(luku);
                }
               
            }
        }
        static void VaihdaKirjain()
        {
            string sana, muutettusana;
            int pituus;
            Console.Clear();
            Console.WriteLine("Anna jokin sana, jonka ensimmäinen ja viimeinen kirjain vaihdetaan keskenään: ");
            sana = Console.ReadLine();
            pituus = sana.Length;
            char[] taulu = new char[pituus];
            for (int i = 0; i < pituus; i++)
                taulu[i] = sana[i];
            taulu[0] = sana[pituus - 1];
            taulu[pituus - 1] = sana[0];
            muutettusana = String.Join(" ", taulu);
            Console.WriteLine("Annoit sanan " + sana + " ja se on muutettu näin: " + muutettusana);
            Console.WriteLine();
            
        }
        static void PosNeg()
        {
            int luku1, luku2;
            Console.Clear();
            palku:
            try
            {
                Console.WriteLine("Syötä ensimmäinen luku: ");
                luku1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Syötä toinen luku: ");
                luku2 = Int32.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Syötä kokonaisluku.");
                goto palku;
            }
            if (luku1 >= 0 && luku2 >= 0)
            {
                Console.WriteLine("Molemmat luvut ovat positiivisia.");
            }
            else if (luku1 < 0 && luku2 < 0)
            {
                Console.WriteLine("Molemmat luvut ovat negatiivisia.");
            }
            else
            {
                Console.WriteLine("Toinen luvuista on negatiivinen ja toinen positiivinen.");
            }
            
        }
        static void Pisinsana()
        {
            Console.Clear();
            string lause;
            Console.WriteLine("Syötä lause, ja ohjelma kertoo mikä lauseen sanoista on pisin: ");
            lause = Console.ReadLine();
            string [] taulu = lause.Split(' ');
            string pisin = taulu[0];
            for (int i = 0; i < taulu.Length; i++)
            {
                if (taulu[i].Length > pisin.Length)
                {
                    pisin = taulu[i];
                }
            }
            Console.WriteLine("Antamasi lause oli {0}, jonka pisin sana oli {1}",lause, pisin);
            
        }
        static void ParittomatLuvut()
        {
            Console.Clear();
            Console.WriteLine("Tämä ohjelma tulostaa parittomat luvut väliltä 1-99");
            for (int i = 1; i < 99; i+=2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
           
        }
        static void KolmellaJaolliset()
        {
            Console.Clear();
            Console.WriteLine("Tämä ohjelma tulostaa kolmella jaolliset luvut väliltä 1-99");
            for(int i = 3; i < 99; i+=3)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("testi");
            Console.ReadLine();
        }
       
    }
}

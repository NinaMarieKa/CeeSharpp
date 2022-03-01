using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia68
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LaskeYhteen(3, 5);
            Fahrenheiteksi(10);
            Perus(8, 5);
            Jakojaannos(5, 2);
            Nimi();
            Ekauusiks();
            Tokauusiks();
            Kolmasuusiks();
            Neljasuusiks();
            Kertotaulu();
        }
        static void LaskeYhteen(int eka, int toka)
        {
            Console.WriteLine("Tulos on: " + (eka + toka));

        }
        static void Fahrenheiteksi(int luku)
        {
            Console.WriteLine(luku + " Fahrenheiteina on " + ((luku * 1.8) + 32));
        }
        static void Perus(int luku1, int luku2)
        {
            int summa, tulo, erotus;
            double osamaara;

            summa = luku1 + luku2;
            tulo = luku1 - luku2;
            erotus = luku1 * luku2;
            osamaara = (double)luku1 / luku2;

            Console.WriteLine("Lukujen yhteenlaskettu summa on: " + summa);
            Console.WriteLine("Lukujen vähennylaskun erotus on: " + tulo);
            Console.WriteLine("Lukujen kertolaskun tulo on: " + erotus);
            Console.WriteLine("Lukujen jakolaskun osamäärä on: " + osamaara);
        }
        static void Jakojaannos(int luku1, int luku2)
        {
            int jakoj = luku1 % luku2;
            Console.WriteLine("Summien jakojäännös on: " + jakoj);
        }
        static void Nimi()
        {
            string nimi;
            Console.WriteLine("Syötä nimesi: ");
            nimi = Console.ReadLine();
            Console.WriteLine("Hei " + nimi);
        }
        static void Ekauusiks()
        {
            int luku1, luku2, summa;
            eualku:
            try
            {
                Console.WriteLine("Anna ensimmäinen luku: ");
                luku1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Anna toinen luku :");
                luku2 = Int32.Parse(Console.ReadLine());
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Antamasi summat eivät olleet kokonaislukuja.");
                goto eualku;
            }
            summa = luku1 + luku2;
            Console.WriteLine("Syöttämiesi lukujen summa on: " + summa);
        }   
        static void Tokauusiks()
        {
            double luku,tulos;
            tualku:
            try
            {
                Console.WriteLine("Syötä luku: ");
                luku = Int32.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Syötä numeerinen arvo.");
                goto tualku;
            }
            tulos = (luku * 1.8) + 32;
            Console.WriteLine(luku + " astetta celsiusta on Fahrenheiteina " + tulos);
        }
        static void Kolmasuusiks()
        {
            int luku1, luku2, summa, tulo, erotus;
            double osamaara;
            kualku:
            try
            {
                Console.WriteLine("Anna ensimmäinen luku: ");
                luku1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Anna toinen luku: ");
                luku2 = Int32.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Syötä luvut numeroina.");
                goto kualku;
            }
            summa = luku1 + luku2;
            tulo = luku1 - luku2;
            erotus = luku1 * luku2;
            osamaara = (double)luku1 / luku2;
            Console.WriteLine("Syöttämiesi lukujen summa on: " + summa + " , tulo on: " + tulo + " , erotus on: " + erotus + " , osamäärä on: " + osamaara);
           
        }
        static void Neljasuusiks()
        {
            int luku1, luku2, jakoj;
            nualku:
            try
            {
                Console.WriteLine("Anna ensimmäinen luku: ");
                luku1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Anna toinen luku: ");
                luku2 = Int32.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Syötä numerot kokonaislukuina.");
                goto nualku;
            }
            jakoj = luku1 % luku2;
            Console.WriteLine("Syöttämiesi summien jakojäännös on: " + jakoj);
           
        }
        static void Kertotaulu()
        {
            string kysymys;
            do
            {
                int kluku;
                kalku:
                try
                {
                    Console.WriteLine("Syötä kokonaisluku väliltä 1-10:");
                    kluku = Int32.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Antamasi luku ei ollut kokonaisluku. Yritä uudelleen.");
                    goto kalku;
                }

                Console.WriteLine(" 1 x " + kluku + " = " + (1 * kluku));
                Console.WriteLine(" 2 x " + kluku + " = " + (2 * kluku));
                Console.WriteLine(" 3 x " + kluku + " = " + (3 * kluku));
                Console.WriteLine(" 4 x " + kluku + " = " + (4 * kluku));
                Console.WriteLine(" 5 x " + kluku + " = " + (5 * kluku));
                Console.WriteLine(" 6 x " + kluku + " = " + (6 * kluku));
                Console.WriteLine(" 7 x " + kluku + " = " + (7 * kluku));
                Console.WriteLine(" 8 x " + kluku + " = " + (8 * kluku));
                Console.WriteLine(" 9 x " + kluku + " = " + (9 * kluku));
                Console.WriteLine(" 10 x " + kluku + " = " + (10 * kluku));

                Console.WriteLine("Haluatko lopettaa? 0 + Enter lopettaaksesi.");
                kysymys = Console.ReadLine();
            } while (kysymys != "0");

        }
    }
}

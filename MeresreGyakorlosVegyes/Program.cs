using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeresreGyakorlosVegyes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Feladat1();
            //Feladat2();
            //Feladat4();
            //Feladat5();
            //Feladat6();
            Feladat7();
        }

        static void Feladat1()
        {
            for (int i = 105; i < 1000; i+=7)
            {
                
                    Console.WriteLine(i);
            }

            Console.ReadKey();
        }

        static void Feladat2()
        {
            int osszeg = 0;
            int db = 0;

            for (int i = 10; i < 96; i++)
            {
                if (i % 5 == 0)
                {
                    if (i % 2 == 0)
                    {
                        db++;
                    }
                    osszeg += i;
                }
            }

            Console.WriteLine("Az összeg: {0}",osszeg);
            Console.WriteLine("A kettővel oszthatóak DB száma: {0}",db);
            Console.ReadKey();
        }


        static void Feladat4()
        {
            Console.WriteLine("Kérem a neved!");
            string nev = Console.ReadLine();

            Console.WriteLine("Kérek egy számot! (1 és 10 között!)");
            int userSzam = Convert.ToInt32(Console.ReadLine());

            Random rnd = new Random();
            int gepSzam = rnd.Next(1, 11);
            if(userSzam>gepSzam)
                Console.WriteLine("{0} nyert!",nev);
            else if(gepSzam> userSzam)
                Console.WriteLine("A gép nyert ezzel a számmal: {0}",gepSzam);
            else
                Console.WriteLine("Döntetlen!");

            Console.ReadKey();
        }

        static void Feladat5()
        {

            Console.WriteLine("Kérem a sugár értékét!");
            double r = Convert.ToDouble(Console.ReadLine());

            double felszin = 4 * Math.PI * Math.Pow(r, 2);
            double terfogat = (4 * Math.PI) / 3 * Math.Pow(r, 3);

            Console.WriteLine("A felszín: {0:0.00}",felszin);
            Console.WriteLine("A térfogat: {0:0.00}",terfogat);

            Console.ReadKey();

        }

        static void Feladat6()
        {
            Random rnd = new Random();

           
            int db55Felett = 0;
            int osszeg = 0;

            for (int i = 0; i < 21; i++)
            {
                int napiCsapadek = rnd.Next(35, 76);
                Console.WriteLine("A(z) {0}. nap csapadék mennyisége: {1}",i+1,napiCsapadek);

                if (napiCsapadek > 55)
                {
                    db55Felett++;
                }

                osszeg += napiCsapadek;
            }

            double atlag = (double)osszeg / 21;
            Console.WriteLine("Az átlag csapadék: {0:0.00}",atlag);

            Console.WriteLine("Ennyiszer volt a napi csapadék értéke 55mm felett: {0}", db55Felett);

            Console.ReadKey();



        }

        static void Feladat7()
        {
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine("A 4 {0}. hatványa: {1}", i, Math.Pow(4,i));
            }

            Console.ReadKey();
        }

        static void Feladat8()
        {

        }


    }
}

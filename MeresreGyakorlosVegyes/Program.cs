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
            Feladat2();
            Feladat4();

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


    }
}

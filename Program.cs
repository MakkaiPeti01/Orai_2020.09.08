using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orai_2020._09._08
{
    class Program
    {
        static void Main(string[] args)
        {
            //gépválasztása
            Random vel = new Random();
            string[] lehetoseg = new string[] { "Kő", "Papír", "Olló"};
            int gep_valaszt = vel.Next(0, 3);
            Console.WriteLine("valasztasok {0} ", lehetoseg[gep_valaszt]);

            //játékosválasztása
            int jatekosvalaszt;
            Console.WriteLine("Kő {0}, Papír {1}, Olló {2}");
            Console.Write("Válasz: ");
            jatekosvalaszt = Convert.ToInt32(Console.ReadLine());

            //csata
            if (jatekosvalaszt == 0 && gep_valaszt == 1 //Gép nyer
                ||
                (jatekosvalaszt == 1 && gep_valaszt == 2)
                ||
                (jatekosvalaszt == 2 && gep_valaszt == 0)
                )
            {
                Console.WriteLine();
                Console.WriteLine("Vesztettél");
            }
            else if (gep_valaszt==jatekosvalaszt) //Döntetlen
            {
                Console.WriteLine();
                Console.WriteLine("Döntetlen");
            }
            else //Játékos nyer
            {
                Console.WriteLine();
                Console.WriteLine("Nyertél");
            }
                Console.WriteLine("Játékos választása: {0}", lehetoseg[jatekosvalaszt]);
                Console.WriteLine("Gép választása: {0}", lehetoseg[gep_valaszt]);
                Console.ReadKey();
        }
    }
}

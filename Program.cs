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
            Console.WriteLine("Játékos választása {0}", lehetoseg[jatekosvalaszt]);
            Console.ReadKey();
        }
    }
}

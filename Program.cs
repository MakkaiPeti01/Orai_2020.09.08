using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orai_2020._09._08
{
    class Program
    {
        static void eredmeny_kiiras(int gep, int ember)
            {
                switch(GepNyer(gep, ember))
                {
                case 0:
                    Console.WriteLine("Döntetelen");
                    break;
                case 1:
                    Console.WriteLine("Skynet nyert");
                    break;
                case 2:
                    Console.WriteLine("Játékos nyert");
                    break;
            }       
            }
        static int GepNyer(int gep, int ember)
        {
            if (ember == 0 && gep == 1 //Gép nyer
                ||
                (ember == 1 && gep == 2)
                ||
                (ember == 2 && gep == 0)
                )
            {
                return 1;
            }
            else if (gep==ember) //Döntetlen
            {
                return 0;
            }
                else //Játékos nyer
            {
                return 2;
            }
        }
        static void Main(string[] args)
        {
            //gépválasztása
            Random vel = new Random();
            string[] lehetoseg = new string[] { "Kő", "Papír", "Olló"};
            int gep_valaszt = vel.Next(0, 3);
            //Console.WriteLine("valasztasok {0} ", lehetoseg[gep_valaszt]);

            //játékosválasztása
            int jatekosvalaszt;
            Console.WriteLine("Kő {0}, Papír {1}, Olló {2}");
            Console.Write("Válasz: ");
            jatekosvalaszt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Gép {0} --- Játékos {1}", lehetoseg[gep_valaszt], lehetoseg[jatekosvalaszt]);
            eredmeny_kiiras(gep_valaszt, jatekosvalaszt);
            Console.ReadKey();
        }
    }
}

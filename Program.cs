﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Orai_2020._09._08
{
    class Program
    {
        static string[] lehetoseg = new string[] { "Kő", "Papír", "Olló"};
        static int gepNyer=0;
        static int jatekosNyer=0;
        static int menet=0;
        static int[] adat=new int[3];
        static void eredmeny_kiiras(int gep, int ember)
            {
                Console.WriteLine("Gép {0} --- Játékos {1}", lehetoseg[gep], lehetoseg[ember]);
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
                gepNyer++;
                return 1;
            }
            else if (gep==ember) //Döntetlen
            {
                return 0;
            }
                else //Játékos nyer
            {
                jatekosNyer++;
                return 2;
            }
        }
        static int jatekos_valaszt()
            {
            Console.WriteLine("Kő {0}, Papír {1}, Olló {2}");
            Console.Write("Válasz: ");
            return Convert.ToInt32(Console.ReadLine());
            }
        static int gepvalasztas()
            {
                 Random vel = new Random();
                 return vel.Next(0, 3);
            }
        static bool Akarjatszani()
            {
            Console.WriteLine("----------------------------");
            Console.Write("Tovább ? [i/n]");
            string valasz=Console.ReadLine().ToLower();
            Console.WriteLine("\n----------------------------");
            if (valasz=="i")
	        {
                return true;
	        }
            else
                return false;
            }
        static void Statisztika()
            {
            Console.WriteLine("Játékos nyer: {0} \t Gép nyer: {1} \t Menetek száma: {2}", jatekosNyer, gepNyer, menet);
            }
        static void Main(string[] args)
        {
            //gépválasztása        
            //Console.WriteLine("valasztasok {0} ", lehetoseg[gep_valaszt]);
            //játéko0sválasztása
            bool tovabb=true;
            statisztika_fajlbol();        
            while (tovabb)
	        {
            menet++;
	        int jatekosvalaszt=jatekos_valaszt();
            int gep_valaszt=gepvalasztas();
            eredmeny_kiiras(gep_valaszt, jatekosvalaszt); 
            tovabb=Akarjatszani();
	        }
            Statisztika();
            statisztika_fajlba();
            Console.ReadKey();         
        }

        private static void statisztika_fajlbol()
        {
            StreamReader stat = new StreamReader("statisztika.txt");                   
            while (!stat.EndOfStream)
            {
                string[] sor = stat.ReadLine().Split(';');
                //adat[0] = int.Parse(sor[0]);
                //adat[1] = int.Parse(sor[1]);
                //adat[2] = int.Parse(sor[2]);
                for (int i = 0; i < adat.Length; i++)
			    {
                   adat[i] = int.Parse(sor[i]);
			    }
                Console.WriteLine("{0} {1} {2}",adat[0],adat[1],adat[2]);
            }                     
            Console.WriteLine("------------Statisztika vége------------");
            stat.Close();
        }
        private static void statisztika_fajlba()
        {
            string adat =menet.ToString()+";"+
                jatekosNyer.ToString()+";"+
                gepNyer.ToString();
            StreamWriter iro=new StreamWriter("statisztika.txt", true);	
            iro.WriteLine(adat);
            iro.Close();
        }
    }
}

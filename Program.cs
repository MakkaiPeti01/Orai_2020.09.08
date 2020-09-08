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
            Random vel = new Random();
            string[] lehetoseg = new string[] { "Kő", "Papír", "Olló"};
            int gep_valaszt = vel.Next(0, 3);
            Console.WriteLine("valasztasok {0} ", lehetoseg[gep_valaszt]);
            Console.ReadKey();
        }
    }
}

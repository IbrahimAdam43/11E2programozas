using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211005_2__feladat_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            feladat3();
            //feladat4();
        }
        static void feladat3()
        {
            Console.Write("Kérek egy számot: ");
            int jelek = Convert.ToInt32(Console.ReadLine());
            if (jelek > 0)
            {
                Console.Write("Pozitív");
            }
            else
            {
                Console.Write("Negatív");
            }
            Console.Read();
        }
        static void feladat4()
        {
        
        }
    }
}

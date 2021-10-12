using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021._10._12
{
    class Program
    {
        static void Main(string[] args)
        {

            //feladat1();
            //feladat1b();
            feladat3();
            feladat3b();
            feladat2();
           
                Console.ReadLine();
        }
        static void feladat1()
        {
            for (int sec = 1; sec <= 20; sec++)
            {
                if (sec%1 == 0)
                {
                    Console.Write(sec + "  ");
                }
            }
        }
        static void feladat1b()
        {
            for (int sec2 = 1; sec2 <= 20; sec2++)
            {
                if (sec2 % 1 == 0)
                {
                    Console.WriteLine(sec2 + "  ");
                }
            }
        }
        static void feladat3()
        {
            for (int a = 1; a <= 30; a++)
            {
               
                if (a %2 == 0)
                {
                    Console.WriteLine(a + " ");
                }

            }
        }
        static void feladat3b()
        {
            for (int a = 1; a <= 30; a++)
            {

                if (a % 2 == 0)
                {
                    Console.Write(a + " ");
                }

            }
        }
        static void feladat2()
        {

        }

    }
}
 
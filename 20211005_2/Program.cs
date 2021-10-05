using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211005_2
{
    class Program
    {
        static void Main(string[] args)
  

        {
           

            Console.Write("Kérek egy számot:");
            int sec = Convert.ToInt32(Console.ReadLine());
            if (sec % 2 == 0)
            {
                Console.WriteLine("Páros a szám");      
            }
            else
            {
                Console.WriteLine("Páratlan");
            }
            Console.Read();
            


        }
    }
}

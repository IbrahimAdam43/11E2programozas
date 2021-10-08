using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021._10._08__2_
{
    class Program
    {
        static void Main(string[] args)
        {
            //feladat1();
            feladat12();
            feladat13();
            Console.WriteLine("nyomj le 1 billentyűt");
            Console.ReadKey();
        }
        static void feladat1()
        {
            Console.Write("Kávéautómata");
            Console.WriteLine("A: Espresso");
            Console.WriteLine("B: Latte macchiato");
            Console.WriteLine("C: Espresso Macchiato");
            Console.WriteLine("D: Caupuucinoi");
            Console.WriteLine("E: Bécsi kávé");
            Console.WriteLine("F: Ristrtto");
            Console.WriteLine("G: Forró Csoki");
            char valasztas = char.Parse(Console.ReadLine());
            switch (valasztas)
            {

                case 'a':
                    Console.WriteLine("Az espresso 130 Ft");
                    break;

                case 'b':
                    Console.WriteLine("Az Latte macchiato 150 Ft");
                    break;

                case 'c':
                    Console.WriteLine("Az Espresso Macchiato 1340 Ft");
                    break;

                case 'd':
                    Console.WriteLine("Az Caupuucinoi 150 Ft");
                    break;

                case 'f':
                    Console.WriteLine("Az Bécsi kávé 120 Ft");
                    break;

                case 'g':
                    Console.WriteLine("A Ristrtto 130 Ft");
                    break;

                default:
                    Console.WriteLine("Nincs ilyen lehetőség");
                    break;
            }
            switch (valasztas.ToString().ToLower())
            {

                case "a":
                    Console.WriteLine("Az espresso 130 Ft");
                    break;
                case "b":
                    Console.WriteLine("Az Latte macchiato 150 Ft");
                    break;
                case "c":
                    Console.WriteLine("Az Espresso Macchiato 1340 Ft");
                    break;

                case "d":
                    Console.WriteLine("Az Caupuucinoi 150 Ft");
                    break;

                case "f":
                    Console.WriteLine("Az Bécsi kávé 120 Ft");
                    break;

                case "g":
                    Console.WriteLine("A Ristrtto 130 Ft");
                    break;

                default:
                    Console.WriteLine("Nincs ilyen lehetőség");
                    break;
            }
        }
       static void feladat12()
        {
            Console.WriteLine("Kérek egy számot: ");
            int sec = int.Parse(Console.ReadLine());
            if (sec < 1 || sec > 12) 
            {
                Console.Write("Nem megfelelő szám!");
            }
            else
            {
                switch (sec)
                {
                    case 1:
                        Console.WriteLine("Január");
                        break;
                    case 2:
                        Console.WriteLine("Február");
                        break;
                    case 3:
                        Console.WriteLine("Március");
                        break;
                    case 4:
                        Console.WriteLine("Április");
                        break;
                    case 5:
                        Console.WriteLine("Május");
                        break;
                    case 6:
                        Console.WriteLine("Június");
                        break;
                    case 7:
                        Console.WriteLine("Július");
                        break;
                    case 8:
                        Console.WriteLine("Augusztus");
                        break;
                    case 9:
                        Console.WriteLine("Szeptember");
                        break;
                    case 10:
                        Console.WriteLine("Október");
                        break;
                    case 11:
                        Console.WriteLine("November");
                        break;
                    case 12:
                        Console.WriteLine("December");
                        break;
                }
               
            }
           
        }
        static void feladat13()
        {
            Console.WriteLine("Kérem a számot: ");
            int sec = int.Parse(Console.ReadLine());
            if (sec < 1 || sec > 12)
            {
                
            }
            switch (sec)
            {
                default:
                    Console.WriteLine("Nem megfelelő szám!");
                    break;
            }
        }
    }
}

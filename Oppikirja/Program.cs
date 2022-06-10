using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Oppikirja
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("\tTERVETULOA");
            Console.WriteLine("---------------------------");
            int valinta ;
            do
            {
                Console.WriteLine(
                    "Vaihtoehtosi \nValitse 1: Jos haluat lisätä opinnon. " +
                    "\nValitse 2: Jos haluat tarkastaa tietoja \n" +
                    "Valitse 3: Jos haluat tyhjentää tiedot " +
                    "\nValitse 4 Jos haluat nähdä Klingon Birf of Preyn" +
                    "\nValitse 5 jos haluat lopettaa.");

                valinta = Convert.ToInt32(Console.ReadLine());

                switch (valinta)
                {
                    case 1:
                        Console.Clear();
                        Method.Methodman();
                        break;
                    case 2:
                        Console.Clear();
                        Method.Redman();
                        break;
                    case 3:
                        Console.Clear();
                        Method.Raekwon();
                        break;
                    case 4:
                        Console.Clear();
                        Method.Ghostfacekillah();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("---------------------------");
                        Console.WriteLine("\tTervemenoa!");
                        Console.WriteLine("---------------------------");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("---------------------------");
                        Console.WriteLine( "\nInvalid choice mate\n");
                        Console.WriteLine("---------------------------");
                        break;
                }
                
            }
            
            while (valinta != 5) ;
        }  
        }
    }






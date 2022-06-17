using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CsvHelper;
using System.Globalization;
using System.Text;
using CsvHelper.Configuration;

namespace Oppikirja
{
    class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<int, Topic> uusTopi = new Dictionary<int, Topic>();
            List<Topic> listuri = new List<Topic>();
            string path = @"C:\Users\Jere\source\repos\Oppikirja\Id.txt";
            string path2 = @"C:\Users\Jere\source\repos\Oppikirja\uusi.csv";
            Topic topi = new Topic();
            Method.OldDirtyBastard(path, topi, uusTopi, listuri);
            int valinta ;

            Console.ForegroundColor
            = ConsoleColor.Blue;
            Console.WriteLine("---------------------------");
            Console.WriteLine("\tTERVETULOA");
            Console.WriteLine("---------------------------");
            Console.ForegroundColor
            = ConsoleColor.White;
            do
            {
                Console.WriteLine(
                    "Vaihtoehtosi \nValitse 1: Jos haluat lisätä opinnon. " +
                    "\nValitse 2: Jos haluat tarkastaa, muokata tai poistaa Titlellä \n" +
                    "Valitse 3: Jos haluat tarkastaa, muokata tai poistaa Id:llä" +
                    "\nValitse 4: Jos haluat tyhjentää tiedot txt kansiosta " +
                    "\nValitse 5: Checkata aiheesi" +
                    "\nValitse 6: jos haluat lopettaa.");
                
                valinta = Convert.ToInt32(Console.ReadLine());
                
                

                switch (valinta)
                {
                    case 1:
                        Console.Clear();
                        Method.Methodman(path,uusTopi,topi, listuri, path2 );
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        Method.Redman(uusTopi, topi, path, listuri);
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        Method.Ghostfacekillah(topi, listuri);
                        Console.Clear();
                        break;
                    case 4:
                        Console.Clear();
                        Method.Raekwon();
                        Console.Clear();
                        break;

                        
                    case 5:
                        Console.Clear();
                        Method.Rza(listuri);
                        Console.Clear();
                        break;
                    case 6:
                        Console.Clear();
                        
                        Console.WriteLine("---------------------------");
                        Console.WriteLine("\tTervemenoa!");
                        Console.WriteLine("---------------------------");
                        Console.WriteLine("\n\n\n\n\nSovellus on myynnissä lähtöhinta: 1 euro enemmän kuin Wolt");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("---------------------------");
                        Console.WriteLine( "\nInvalid choice mate\n");
                        Console.WriteLine("---------------------------");
                        
                        break;
                }
               
                
            }
            
            while (valinta != 6) ;
        }  
        }
    }






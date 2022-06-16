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
            foreach (var i in listuri)
            {
                Console.WriteLine(i.Id);
                Console.WriteLine(i.Title);
            }


            Console.WriteLine("---------------------------");
            Console.WriteLine("\tTERVETULOA");
            Console.WriteLine("---------------------------");

            do
            {
                Console.WriteLine(
                    "Vaihtoehtosi \nValitse 1: Jos haluat lisätä opinnon. " +
                    "\nValitse 2: Jos haluat muokata Titlellä \n" +
                    "Valitse 3: Jos haluat muokata Idllä" +
                    "\nValitse 4 Jos haluat tyhjentää tiedot  " +
                    "\nValitse 5 jos haluat lopettaa.");
                foreach (var i in listuri)
                {
                    Console.WriteLine(i.Id);
                    Console.WriteLine(i.Title);
                }
                valinta = Convert.ToInt32(Console.ReadLine());
                

                switch (valinta)
                {
                    case 1:
                        Console.Clear();
                        Method.Methodman(path,uusTopi,topi, listuri, path2 );
                        
                        break;
                    case 2:
                        Console.Clear();
                        Method.Redman(uusTopi, topi, path, listuri);
                        break;
                    case 3:
                        Console.Clear();
                        Method.Ghostfacekillah(topi, listuri);
                        break;
                    case 4:
                        Console.Clear();
                        Method.Raekwon();
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





